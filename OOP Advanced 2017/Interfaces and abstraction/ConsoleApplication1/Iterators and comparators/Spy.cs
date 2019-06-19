using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


public class Spy
{
    public string StealFieldInfo(string classToInvestigate,params string[] fieldsToInvestigate)
    {
        var sb = new StringBuilder(string.Format("Class under investigation: {0}" + Environment.NewLine, classToInvestigate));
        var fields = Type.GetType(classToInvestigate).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        var classInstance = Activator.CreateInstance(Type.GetType(classToInvestigate));
        foreach(var field in fields)
        {
            if(fieldsToInvestigate.Contains(field.Name))
            {
                sb.AppendLine(string.Format("{0} - {1}",field.Name,field.GetValue(classInstance)));
            }
        }
        return sb.ToString();
    }
}
