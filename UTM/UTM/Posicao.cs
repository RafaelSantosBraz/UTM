﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM
{
    class Posicao
    {
        private char simbolo;
        private Posicao ant;
        private Posicao prox;

        public Posicao()
        {
            Simbolo = '\0';
            Ant = null;
            Prox = null;
        }

        public char Simbolo { get => simbolo; set => simbolo = value; }
        internal Posicao Ant { get => ant; set => ant = value; }
        internal Posicao Prox { get => prox; set => prox = value; }
    }
}
