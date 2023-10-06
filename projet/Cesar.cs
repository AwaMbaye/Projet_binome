public class Cesar
{
    public string mot;
    public int decalage;
    public Cesar(string mot, int decalage)
    {
        this.mot = mot;
        this.decalage = decalage;
    }
    public string Codage()
    {
        string motcode = "";
        foreach (char caractere in mot)
        {
            if (char.IsLetter(caractere))
            {
                char baseletter = char.IsUpper(caractere) ? 'A' : 'a';
                char caracterecode = (char)(((caractere - baseletter + decalage) % 26) + baseletter);
                motcode += caracterecode;
            }
            else
            {
                motcode += caractere;
            }
        }
        return motcode;
    }
    public string Decodage(string textecode, int decal)
    {
        mot = textecode;
        decalage = 26 - decal;
        return Codage();
    }
}