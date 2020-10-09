﻿using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace winform
{
    public partial class frmAlta : Form
    {
        private Pokemon pokemon = null;
        public frmAlta()
        {
            InitializeComponent();
        }
        public frmAlta(Pokemon poke)
        {
            InitializeComponent();
            pokemon = poke;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            PokemonNegocio negocio = new PokemonNegocio();
            if (pokemon == null)
                pokemon = new Pokemon();

            pokemon.Nombre = txtNombre.Text;
            pokemon.Descripcion = txtDescripcion.Text;
            pokemon.Tipo = (Tipo)cboTipo.SelectedItem;
            pokemon.UrlImage = txtImagen.Text;

            if (pokemon.Id == 0)
                negocio.agregar(pokemon);
            else
                negocio.modificar(pokemon);

            MessageBox.Show("Operacion realizada exitosamente", "Exito");
            Close();


        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            TipoNegocio tipoNegocio = new TipoNegocio();

            cboTipo.DataSource = tipoNegocio.listar();
            cboTipo.ValueMember = "Id";
            cboTipo.DisplayMember = "Descripcion";

            cboTipo.SelectedIndex = -1;

            if(pokemon != null)
            {
                txtNombre.Text = pokemon.Nombre;
                txtDescripcion.Text = pokemon.Descripcion;
                cboTipo.SelectedValue = pokemon.Tipo.Id;

                Text = "Modificacion Pokemon";
            }
        }
    }
}
