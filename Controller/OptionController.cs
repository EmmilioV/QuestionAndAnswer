using Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    
    public class OptionController
    {
        //TODO: lista de opciones donde questionid
        public List<Option> GenerateOptions(string questionId)
        {
            Option option1 = new Option("option1", questionId, "Bogotá", true);
            Option option2 = new Option("option2", questionId, "Medellin", false);
            Option option3 = new Option("option3", questionId, "Cucuta", false);
            Option option4 = new Option("option4", questionId, "Santa Marta", false);


            List<Option> options = new List<Option>();
            options.Add(option1);
            options.Add(option2);
            options.Add(option3);
            options.Add(option4);

            return options;
        }

    }
}
