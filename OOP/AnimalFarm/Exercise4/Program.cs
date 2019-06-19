using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var inputPersons = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        var inputProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        List<Person> listOfPeople = new List<Person>();
        for(int i = 0; i < inputPersons.Length; i++)
        {
            var values = inputPersons[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            listOfPeople.Add(new Person(values[0],double.Parse(values[1])));
        }

        List<Product> listOfProducts = new List<Product>();
        for(int i = 0; i < inputProducts.Length;i++)
        {
            var values = inputProducts[i].Split(new char[] {'='},StringSplitOptions.RemoveEmptyEntries);
            listOfProducts.Add(new Product(values[0], double.Parse(values[1])));
        }

        var command = Console.ReadLine();
        while(command != "End")
        {
            var values = command.Split();

            var product = listOfProducts.Where(x => x.Name == values[1]).Select(x =>x).FirstOrDefault();
            var person = listOfPeople.Where(x => x.Name == values[0]).Select(x => x).FirstOrDefault();
            try
            {
                person.BuyProduct(product);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            command = Console.ReadLine();
        }

        foreach(var person in listOfPeople)
        {
            Console.Write(person.Name + "-");
            if(person.BagOfProducts.Count == 0)
            {
                Console.WriteLine("Nothing bought");
            }
            else
            {
                foreach (var product in person.BagOfProducts)
                {

                    Console.Write(product.Name + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
