﻿using System;

namespace ıf_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
          int time= DateTime.Now.Hour;

           if(time>=6 &&  time<11   )
          Console.WriteLine("Günaydin!:");
           
           else if (time<=18   )
          Console.WriteLine("İyi Günler!:");
          else
          Console.WriteLine("İyi Geceler!:");

          string sonuc= time<=18 ? "İyi Günler!": "İyi Geceler!";
         sonuc = time>=6 && time<11 ? "Günaydin!" : time<=18 ? "İyi Günler!:":"İyi Geceler";
         Console.WriteLine(sonuc);

        }
    }
}
