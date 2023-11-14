namespace EU2
{
    internal class Program
    {



        static List<Adatok> sorrend(List<Adatok> a)
        { 
        
        var f1=a.Where(a => !a.Csatlakozas.Contains("Nem tag")).ToList();
            var f1b = f1.OrderBy(x => x.Fovaros).ToList();
            return f1b;
        
        }
        static List<Adatok>Penz(List<Adatok> b)
        {
            var f2 = b.Where(b => b.Penznem.Contains("EUR")).ToList(); 
            
            return f2;


        }


        static void Main(string[] args)
        {

 
            var europa=new List<Adatok>();
            using (var sr = new StreamReader(@"..\..\..\src\eu.txt"))
            {
                while (!sr.EndOfStream)
                {
                    europa.Add(new Adatok(sr.ReadLine()));
                }
            
            }
            foreach (var item in europa)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"1. feladat");
            foreach (var item in sorrend(europa))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"2. feladat");
            foreach (var item in Penz(europa))
            {
                Console.WriteLine($"{item.Orszag} {item.Fovaros}");
            }
        }

      
    }
}