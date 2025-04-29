using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DiplomProject.Models.Helpers
{
	public class DocumentCreator
	{
		private string _header = $"Распределение рабочего состава на оборудование ({DateTime.Now.ToShortDateString()})\n";
		private string _fileName = $"Распределение {DateTime.Now.ToShortDateString()}";

		public void CreateWordFile(List<DistributionModel> distribution, string file)
		{
			using WordprocessingDocument wordDocument = WordprocessingDocument.Create($"{file}/{_fileName}.docx", WordprocessingDocumentType.Document);

			MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
			mainPart.Document = new Document();

			Body body = CreateContent(distribution);
			mainPart.Document.Append(body);
			mainPart.Document.Save();
		}

		public async Task CreateTxtFile(List<DistributionModel> distribution, string file)
		{
			using StreamWriter writer = new StreamWriter($"{file}/{_fileName}.txt");
			StringBuilder builder = new StringBuilder();

			builder.AppendLine(_header);

            foreach (var row in distribution)
				builder.AppendLine($"{row.EquipmentId}  -  {row.WorkerFullName} (Id: {row.WorkerId})");

			await writer.WriteLineAsync(builder.ToString());
        }

		private Body CreateContent(List<DistributionModel> distribution)
		{
			Body body = new Body();
			Table table = new Table();

			TableProperties tblProperties = new TableProperties(new TableWidth() { Type = TableWidthUnitValues.Pct, Width = "100%" });
			table.AppendChild(tblProperties);

			TableRow headerRow = new TableRow();
			headerRow.Append(new TableCell(new Paragraph(new Run(new Text("ID Оборудования")))));
			headerRow.Append(new TableCell(new Paragraph(new Run(new Text("ФИО Работника")))));
			headerRow.Append(new TableCell(new Paragraph(new Run(new Text("ID Работника")))));
			table.Append(headerRow);

			foreach (var item in distribution)
			{
				TableRow row = new TableRow();
				row.Append(new TableCell(new Paragraph(new Run(new Text(item.EquipmentId)))));
				row.Append(new TableCell(new Paragraph(new Run(new Text(item.WorkerFullName)))));
				row.Append(new TableCell(new Paragraph(new Run(new Text(item.WorkerId)))));
				table.Append(row);
			}

			Paragraph titleParagraph = new Paragraph(new Run(new Text($"{_header}")));
			titleParagraph.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
			
			body.Append(titleParagraph);
			body.Append(new Paragraph(new Run(new Text(""))));
			body.Append(table);
			return body;
		}
	}
}
