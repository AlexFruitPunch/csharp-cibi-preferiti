//dichiarazione array cibi preferiti dal migliore al meno peggio

string [] cibiPreferiti = { "Coxinhas", "Carbonara", "Tiramisù", "Mango" ,"Spaghetti aglio olio e peperoncino", "Papaya", "Anacardi", "Cheesecake", "Crapfen"};

//Stampo a video quanti sono i cibi preferiti
Console.WriteLine("Ci sono un totale di " + cibiPreferiti.Length + " cibi nella tua lista preferiti");


Console.WriteLine("Ecco la lista dei tuoi cibi preferiti");

//Stampo gli elementi della lista
for (int i = 0; i < cibiPreferiti.Length; i++) {
    Console.WriteLine("- " + cibiPreferiti[i]);
}

//ora dirò qualè il tuo cibo preferito
Console.Write("Il tuo cibo preferito è: " + cibiPreferiti[0] + "\n");

//ora dirò qualè il tuo cibo preferito ma non troppo
Console.Write("Il tuo cibo un po' meno preferito è: " + cibiPreferiti[cibiPreferiti.Length - 1] + "\n");

//stampa del cibo a metà classifica

if (cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine("il tuo cibo di metà classifica è: " + cibiPreferiti[(cibiPreferiti.Length/2)-1]);
}
else
{
    Console.WriteLine("Essendo una classifica dispari saranno 2 i numeri a metà classifica\n");
    Console.WriteLine("cibo di metà classifica 1: " + cibiPreferiti[((int)(cibiPreferiti.Length / 2)) - 1]);
    Console.WriteLine("cibo di metà classifica 2: " + cibiPreferiti[(int)(cibiPreferiti.Length / 2)]);
}