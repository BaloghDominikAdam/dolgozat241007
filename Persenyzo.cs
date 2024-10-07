using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dolgozat241007
{
    internal class Persenyzo
    {
        public string Nev { get; set; }
        public int Szulido { get; set; }
        public int Rajtszam {  get; set; }
        public bool Neme {  get; set; }
        public int eletkorcsop {  get; set; }

        public Dictionary<string, TimeSpan> persenyzoidoi = new Dictionary<string, TimeSpan>();


        public Persenyzo(string sor)
        {
            var v = sor.Split(';');
            Nev = v[0];
            Szulido = Convert.ToInt32(v[1]);
            Rajtszam = Convert.ToInt32(v[2]);
            Neme = (v[4]) == "n"; 
            persenyzoidoi.Add("uszasideje", TimeSpan.Parse(v[5]));
            persenyzoidoi.Add("elsodepo", TimeSpan.Parse(v[6]));
            persenyzoidoi.Add("kerekpar", TimeSpan.Parse(v[6]));
            persenyzoidoi.Add("masodikdepo", TimeSpan.Parse(v[8]));
            persenyzoidoi.Add("futido", TimeSpan.Parse(v[9]));

        }

        public override string ToString()
        {
            return
                $"\t{Nev} a versenyző neve \n" +
                $"\tÉvben született: {Szulido}\n" +
                $"\t{Rajtszam} a rajtszáma\n" +
                $"\t{(Neme ? "Nő" : "Férfi")} a neme\n" +
                $"\t{eletkorcsop}-ba tartozik\n"+
                $"\tPersenző idői: \n"+
                $"\tÚszásideje:{persenyzoidoi["uszasideje"]} \n"+
                $"\tElső depoja: {persenyzoidoi["elsodepo"]}"+
                $"\tKerékpározási ideje: {persenyzoidoi["kerekpar"]}"+
                $"\tMásodik depoja: {persenyzoidoi["masodikdepo"]}"+
                $"\tA futás ideje: {persenyzoidoi["futido"]}";
        }
    }
}
