using System.Threading.Tasks;
using System.IO;
using OneBlink.SDK.Model;
namespace OneBlink.SDK
{
  public class PdfClient
  {
    private OneBlinkPdfClient oneBlinkPdfClient;

    public PdfClient(string accessKey, string secretKey, TenantName tenantName = TenantName.ONEBLINK)
        {
            this.oneBlinkPdfClient = new OneBlinkPdfClient(
                accessKey,
                secretKey,
                tenant: new Tenant(tenantName)
            );
        }
    public async Task<Stream> GetSubmissionPdf(int formId, string submissionId)
    {
      string url = "/forms/" + formId.ToString() + "/submissions/" + submissionId + "/pdf-document";
      return await this.oneBlinkPdfClient.PostRequest(url);
    }

    public async Task<Stream> GeneratePdf(GeneratePdfOptionsRequest options)
    {
        string url = "/pdf-document";
        return await this.oneBlinkPdfClient.PostRequest(url, options);
    }
  }
}
