//dichiarazione array cibi preferiti dal migliore al meno peggio

string [] cibiPreferiti = { "Coxinhas", "Carbonara", "Tiramisù", "Mango" ,"Spaghetti aglio olio e peperoncino", "Papaya", "Anacardi", "Cheesecake", "Crapfen", "Guava" };

//Stampo a video quanti sono i cibi preferiti
Console.WriteLine("Ci sono un totale di " + cibiPreferiti.Length + " nella tua lista di cibi preferiti");


Console.WriteLine("Ecco la lista dei tuoi cibi preferiti");

//Stampo gli elementi della lista
for (int i = 0; i < cibiPreferiti.Length; i++) {
    Console.WriteLine("- " + cibiPreferiti[i]);
}
