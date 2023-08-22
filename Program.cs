// See https://aka.ms/new-console-template for more information
islem algoritma = new islem();
List<string> lists = new List<string>();
List<int> listi = new List<int>();
List<string> removed = new List<string>();
string s = algoritma.get();
algoritma.addToarray(s,lists,listi);
algoritma.remover(lists,listi,removed);
algoritma.writer(removed);

class islem
{
    public string get()
    {
        Console.WriteLine("Please enter word1,index1 word2,index2...: ");
        string s = Console.ReadLine();
        return s;
    }
    public void addToarray(string s, List<string> slist, List<int> ilist)
    {
        string[] ss = s.Split(" ");
        foreach (string sss in ss)
        {
            string[] ssss = sss.Split(",");
            slist.Add(ssss[0]);
            ilist.Add(int.Parse(ssss[1]));
        }
    }
    public void remover(List<string> slist, List<int> ilist, List<string> removed)
    {
        string nword = "";
        for (int i = 0;i < slist.Count;i++) 
        {
            if (ilist[i] > slist[i].Count())
            {
                nword = slist[i];
            }
            else
            {
                nword = slist[i].Remove(ilist[i], 1);
            }
            removed.Add(nword);
        }
    }
    public void writer(List<string> l)
    {
        foreach (string s in l)
        {
            Console.WriteLine(s);
        }
    }
}