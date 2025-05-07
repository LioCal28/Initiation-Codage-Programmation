using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Question
{
    public string Text { get; set; }
    public string[] Choice { get; set; }
    public int IndexBonneReponse { get; set; }

    public Question(string text, string[] choice, int indexBonneReponse)
    {
        Text = text;
        Choice = choice;
        IndexBonneReponse = indexBonneReponse;
    }

public bool EstBonneReponse(int indexUser)
{
    return indexUser == IndexBonneReponse;
}

}