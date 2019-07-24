<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>itext7.pdfhtml</NuGetReference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>iText.Html2pdf</Namespace>
  <Namespace>iText.Kernel.Pdf</Namespace>
  <Namespace>iText.Layout</Namespace>
</Query>

void Main()
{
	// url of html
	var url = "http://192.168.0.30:8080/coverpage.html";
	// location on where it will be saved
	var path = "C:\\temp\\filename.pdf";

	var htmlString = GetHtmlFromPage(url);
	createPdfbyDocument(url, htmlString, path);

	Util.Cmd(path);

}

// Define other methods and classes here

string GetHtmlFromPage(string link)
{
	using (System.Net.WebClient client = new System.Net.WebClient())
	{
		return client.DownloadString(link);
	}
}

void createPdfbyDocument(string baseUri, string source, string dest)
{
	ConverterProperties properties = new ConverterProperties();
	properties.SetBaseUri(baseUri);
	PdfWriter writer = new PdfWriter(dest);
	PdfDocument pdf = new PdfDocument(writer);
	Document document =
		HtmlConverter.ConvertToDocument(source, pdf, properties);
	document.Close();
}