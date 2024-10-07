using dolgozat241007;
using System.Text;
using System.IO;
using System;
using System.Threading.Tasks;
namespace dolgozat241007;


List<Persenyzo> persenyzok = [];

using StreamReader sr = new (
    path: @"forras.txt",
    encoding: Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) persenyzok.Add(new (sr.ReadLine()));

Console.WriteLine("1. feladat: " +
    $"{persenyzok.Count}db versenyző fejezte be a versenyt!");