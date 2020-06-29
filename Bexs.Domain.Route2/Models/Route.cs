using Bexs.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bexs.Domain.Models
{
    public class Route
    {
        public IList<Stretch> Stretchs { get; private set; }
        public Stretch Stretch { get; private set; }
        public Local From { get; private set; }
        public Local To { get; private set; }
        public int Value { get; private set; }


        public Route(string from, string to, int value = 0)
        {
            AssertionConcern.AssertArgumentNotNull(from, "The From must be provided.");
            AssertionConcern.AssertArgumentNotNull(to, "The To must be provided.");


            AssertionConcern.AssertArgumentLength(from, 3,3, "The Length of From shoud be 3.");
            AssertionConcern.AssertArgumentLength(to, 3,3, "The To of From shoud be 3.");

            this.From = new Local(from);
            this.To = new Local(to);
            this.Value = value;
            this.Stretchs = new List<Stretch>();
        }

        /// <summary>
        /// Adiciona um item na coleção de trechos da rorta
        /// </summary>
        /// <param name="stretch"></param>
        public void AddStretch(Stretch stretch)
        {
            Stretchs.Add(stretch);
        }

        public IList<Stretch> NewRoute(Local from, Local to)
        {
            AssertionConcern.AssertArgumentNotNull(from, "The From must be provided.");
            AssertionConcern.AssertArgumentNotNull(to, "The To must be provided.");

            return null;
        }

        /// <summary>
        /// Incrementa o valor total da rota na propriedade value
        /// </summary>
        /// <param name="value">inteiro não negativo.</param>
        internal void AddValue(int value)
        {
            this.Value += value;
        }

        /// <summary>
        /// Utilize para transformar as informações contidas na classe para o formato string.
        /// </summary>
        /// <returns>String com a rota e o valor</returns>
        public string Build()
        {
            StringBuilder result = new StringBuilder();

            if (Stretchs.Count > 1)
            {

                for (int i = 0; i < Stretchs.Count; i++)
                {
                    if (i < Stretchs.Count - 1)
                    {
                        result.Append(Stretchs[i].from.AirPort);
                        result.Append(" - ");
                    }
                    else
                    {
                        result.Append(Stretchs[i].from.AirPort);
                        result.Append(" - ");
                        result.Append(Stretchs[i].to.AirPort);
                        result.Append(" - ");
                        result.Append(Value);
                    }
                }
            }
            else
            {
                result.Append(From.AirPort);
                result.Append(" - ");
                result.Append(To.AirPort);
                result.Append(" - ");
                result.Append(Value);
            }

            return result.ToString();
        }
    }
}
