Regnvejrsstatistik
============

Lavet af: Emma Midjord Niclasen




Beskrivelse
------------
I dette projet skal user indtaste, hvor mange mm det har regnet pr.dag. i x antal dage, som bliver gemt i listen 'daysList'.
Efter det får brugeren 4 muligheder at se værdierne: 
* Gennemsnit 
* Maksimumværdi
* Minimumværdi
* Oversigt over alle indtastede værdier
  





Metoder
--------
Alle inputs gemmes i en List, og der er brugt Linq framework til alle beregninsmetoderne.

Kode eksempel:

~~~c#
 class Beregninger
        {
      public List<double> daysList = new List<double>();

      public void Gennemsnittet()
            {
                double gennemsnit = daysList.Average();
                Console.WriteLine("\n\nGennemsnittet for de indtastede værdier er: {0}mm", gennemsnit);
            }
}
~~~

    


Known issues
------------

Når de indtaste værdier bliver printet ud kunne jeg ikke finde ud af, hvordan de blev printet ud ***med*** decimaler.







