using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    static bool validresult = true;
    public string verification(string xml, string xmls)
    {

        validresult = true;
        XmlReaderSettings booksSettings = new XmlReaderSettings();
        booksSettings.Schemas.Add(null, xmls);
        booksSettings.ValidationType = ValidationType.Schema; 
        booksSettings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
        booksSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;


        booksSettings.ValidationEventHandler += new ValidationEventHandler(booksSettingsValidationEventHandler);
        
        XmlReader books = XmlReader.Create(xml, booksSettings);
        while (books.Read()) { }
        if (validresult)
            return "no error";
        else
            return "error";
    }

    public string xPathSearch(string xml, string pathExpression)
    {
        int lastind = pathExpression.LastIndexOf("/");
        string firsttag = pathExpression.Substring(0, lastind);
        string secondtag = pathExpression.Substring(lastind+1);
        string result = "";
        XPathDocument dx = new XPathDocument(xml);
        XPathNavigator nav = dx.CreateNavigator();
        XPathNodeIterator iterator = nav.Select(firsttag);
     
        while (iterator.MoveNext())
        {
            XPathNodeIterator it = iterator.Current.Select(secondtag);
            it.MoveNext();
            string data = it.Current.Value;
            result = result + " || " + data;
        }
        return result;
    }
    
    static void booksSettingsValidationEventHandler(object sender, ValidationEventArgs e)
    {
        if (e.Severity == XmlSeverityType.Warning)
        {
            validresult = false;
            Console.Write("WARNING: ");
            Console.WriteLine(e.Message);
        }
        else if (e.Severity == XmlSeverityType.Error)
        {
            validresult = false;

            Console.Write("ERROR: ");
            Console.WriteLine(e.Message);
        }
    }

}
