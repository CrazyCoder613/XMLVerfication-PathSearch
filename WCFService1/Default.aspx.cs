using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnValidate_Click(object sender, EventArgs e)
    {
        string url = @"http://localhost:62675/Service.svc/verify?xml=" + xmlURL1.Text + "&xmls=" + xmlsURL.Text;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        WebResponse response = request.GetResponse(); 
        Stream dataStream = response.GetResponseStream();
        StreamReader sreader = new StreamReader(dataStream);
        var responsereader = sreader.ReadToEnd();
        response.Close();
        string validation = JsonConvert.DeserializeObject<string>(responsereader);
        validationLabel.Text = validation;
    }

    protected void btnxPathSearch_Click(object sender, EventArgs e)
    {
        string url = @"http://localhost:62675/Service.svc/xpath?xml=" + xmlURL2.Text + "&exp=" + xpath.Text;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader sreader = new StreamReader(dataStream);
        var responsereader = sreader.ReadToEnd();
        response.Close();
        string validation = JsonConvert.DeserializeObject<string>(responsereader);
        pathLabel.Text = validation;
    }
}