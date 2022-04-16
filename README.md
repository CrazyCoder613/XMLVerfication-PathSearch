# XMLVerfication-PathSearch
Validate xml schema using xls file and search using xmlpath
 Develop a Web service (.svc) with two of the APIs listed below. The node mentioned in the sub questions below includes every component (element, content, and attribute) showing the XML tree in part 1.  
1 API “verification” takes the URL of an XML (.xml) file and the URL of the corresponding XMLS (.xsd) file as input and validates the XML file against the corresponding XMLS (XSD) file. The API returns “No Error” or an error message showing the available information at the error point. You must use files that you create in the previous questions, with and without fault injection, as the test case. 
 However, your service operation should work for other test cases too.     
2 Web operation “XPathSearch” takes the URL of an XML (.xml) file and a path expression as input. It returns the path expression value of the given path. It could be a list of nodes, the content value, etc., depending on the path give. For this you can assume that your API support only simple XPath expressions (returning values for a given node in the XML document such as /Courses/Course, 
