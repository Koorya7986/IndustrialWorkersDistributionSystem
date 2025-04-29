using Accord.Fuzzy;
using DiplomProject.Models.Entities;
using System.Configuration;

namespace DiplomProject.Models.Helpers
{
	public class FuzzyDistributionSystem
	{
		public List<EquipmentPossibilityFailureModel> CreateEquipmentPossibilityFailureList(List<Equipment> equipment)
		{
			List<EquipmentPossibilityFailureModel> output = new List<EquipmentPossibilityFailureModel>();

			string avgSeverityPointsAFPoints = ConfigurationManager.AppSettings["AverageErrorSeverityAccessoryFunctionPoints"]!;
			string errorsAmountAFPoints = ConfigurationManager.AppSettings["1dayErrorsAmountAccessoryFunctionPoints"]!;

			if (string.IsNullOrWhiteSpace(avgSeverityPointsAFPoints) || string.IsNullOrWhiteSpace(errorsAmountAFPoints))
				throw new Exception("Не указаны параметры функции принадлежности переменной 'среднее значение серьёзности' в конфигурационном файле");

			foreach (var eq in equipment)
            {
				EquipmentPossibilityFailureModel model = new EquipmentPossibilityFailureModel();
				model.Id = eq.Id;
				model.Possibility = CalculatePossibilityFailure(eq, avgSeverityPointsAFPoints, errorsAmountAFPoints);
				output.Add(model);
            }

            return output;
		}


		private double CalculatePossibilityFailure(Equipment equipment, string avgSevPointsAF, string errAmountPointsAF)
		{
			double avgSeverity = CalculateAverageSeverity(equipment.Errors, 1);
			DateTime startDate = DateTime.Now.AddDays(-2);
			int errorsAmount = equipment.Errors.Where(er => er.Date >= startDate).Count();

			LinguisticVariable averageErrorLV = new LinguisticVariable("AverageError", 1, 5);
			LinguisticVariable amountErrorLV = new LinguisticVariable("AmountError", 1, 120);

			var avgParts = avgSevPointsAF.Split('|');
			var avgSevAFLow = avgParts[0].Split(' ');
			var avgSevAFMed = avgParts[1].Split(' ');
			var avgSevAFHigh = avgParts[2].Split(' ');

			var amountParts = errAmountPointsAF.Split('|');
			var amountAFLow = amountParts[0].Split(' ');
			var amountAFMed = amountParts[1].Split(' ');
			var amountAFHigh = amountParts[2].Split(' ');

			TrapezoidalFunction averageErrorLVtf1 = new TrapezoidalFunction(float.Parse(avgSevAFLow[0]), float.Parse(avgSevAFLow[1]), TrapezoidalFunction.EdgeType.Right);
			TrapezoidalFunction averageErrorLVtf2 = new TrapezoidalFunction(float.Parse(avgSevAFMed[0]), float.Parse(avgSevAFMed[1]), float.Parse(avgSevAFMed[2]), float.Parse(avgSevAFMed[3]));
			TrapezoidalFunction averageErrorLVtf3 = new TrapezoidalFunction(float.Parse(avgSevAFHigh[0]), float.Parse(avgSevAFHigh[1]), TrapezoidalFunction.EdgeType.Left);

			TrapezoidalFunction amountErrorLVtf1 = new TrapezoidalFunction(int.Parse(amountAFLow[0]), int.Parse(amountAFLow[1]), TrapezoidalFunction.EdgeType.Right);
			TrapezoidalFunction amountErrorLVtf2 = new TrapezoidalFunction(int.Parse(amountAFMed[0]), int.Parse(amountAFMed[1]), int.Parse(amountAFMed[2]), int.Parse(amountAFMed[3]));
			TrapezoidalFunction amountErrorLVtf3 = new TrapezoidalFunction(int.Parse(amountAFHigh[0]), int.Parse(amountAFHigh[1]), TrapezoidalFunction.EdgeType.Left);
			
			FuzzySet fsSmall = new FuzzySet("Small", averageErrorLVtf1);
			FuzzySet fsAverage = new FuzzySet("Average", averageErrorLVtf2);
			FuzzySet fsBig = new FuzzySet("Big", averageErrorLVtf3);

			averageErrorLV.AddLabel(fsSmall);
			averageErrorLV.AddLabel(fsAverage);
			averageErrorLV.AddLabel(fsBig);

			FuzzySet fsFew = new FuzzySet("Few", amountErrorLVtf1);
			FuzzySet fsMedian = new FuzzySet("Median", amountErrorLVtf2);
			FuzzySet fsLarge = new FuzzySet("Large", amountErrorLVtf3);

			amountErrorLV.AddLabel(fsFew);
			amountErrorLV.AddLabel(fsMedian);
			amountErrorLV.AddLabel(fsLarge);

			LinguisticVariable possibilityFailureLV = new LinguisticVariable("PossibilityFailure", 0, 100);

			TrapezoidalFunction possibilityFailureLVtf1 = new TrapezoidalFunction(0, 20, 30);
			TrapezoidalFunction possibilityFailureLVtf2 = new TrapezoidalFunction(25, 50, 65);
			TrapezoidalFunction possibilityFailureLVtf3 = new TrapezoidalFunction(30, 75, 100);

			FuzzySet fsLow = new FuzzySet("Low", possibilityFailureLVtf1);
			FuzzySet fsMedium = new FuzzySet("Medium", possibilityFailureLVtf2);
			FuzzySet fsHigh = new FuzzySet("High", possibilityFailureLVtf3);

			possibilityFailureLV.AddLabel(fsLow);
			possibilityFailureLV.AddLabel(fsMedium);
			possibilityFailureLV.AddLabel(fsHigh);

			Database db = new Database();
			db.AddVariable(averageErrorLV);
			db.AddVariable(amountErrorLV);
			db.AddVariable(possibilityFailureLV);

			
			InferenceSystem inferenceSystem = new InferenceSystem(db, new CentroidDefuzzifier(100));
			inferenceSystem.NewRule("Rule 1", "IF AverageError is Small and AmountError is Few then PossibilityFailure is Low");
			inferenceSystem.NewRule("Rule 2", "IF AverageError is Small and AmountError is Median then PossibilityFailure is Low");
			inferenceSystem.NewRule("Rule 3", "IF AverageError is Small and AmountError is Large then PossibilityFailure is Medium");

			inferenceSystem.NewRule("Rule 4", "IF AverageError is Average and AmountError is Few then PossibilityFailure is Low");
			inferenceSystem.NewRule("Rule 5", "IF AverageError is Average and AmountError is Median then PossibilityFailure is Medium");
			inferenceSystem.NewRule("Rule 6", "IF AverageError is Average and AmountError is Large then PossibilityFailure is High");

			inferenceSystem.NewRule("Rule 7", "IF AverageError is Big and AmountError is Few then PossibilityFailure is Medium");
			inferenceSystem.NewRule("Rule 8", "IF AverageError is Big and AmountError is Median then PossibilityFailure is High");
			inferenceSystem.NewRule("Rule 9", "IF AverageError is Big and AmountError is Large then PossibilityFailure is High");

			inferenceSystem.SetInput("AverageError", (float)avgSeverity);
			inferenceSystem.SetInput("AmountError", errorsAmount);

			float result = inferenceSystem.Evaluate("PossibilityFailure") / 100;

			if (equipment.Errors.Count > 15 || equipment.Errors.Where(er => int.Parse(er.Severity) > 3).Count() > 10)
				result += 0.2f;
			else if (equipment.Errors.Count > 5 && equipment.Errors.Where(er => int.Parse(er.Severity) > 3).Count() > 5)
				result += 0.1f;
			return result;
		}

		private double CalculateAverageSeverity(List<Error> errors, int days)
		{
			DateTime startDate = DateTime.Now.AddDays(-(days + 1));
			return errors.Where(er => er.Date >= startDate).Average(er => int.Parse(er.Severity));
		}
	}
}
