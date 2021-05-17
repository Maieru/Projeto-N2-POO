using Projeto_N2_POO.Classes;
using Projeto_N2_POO.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_N2_POO.Forms
{
    public partial class frCadastro : frBase
    {
        public frCadastro()
        {
            InitializeComponent();
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {

            DialogResult aux = MessageBox.Show("Você tem certeza?", "Atenção !",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (aux == DialogResult.Yes)
            {
                DeletaArquivos();
                AdicionaPedagios();
                AdicionarMarcas();
                AdicionarModelos();
                AdicionarVeiculos();
            }
        }

        private static void AdicionarVeiculos()
        {
            VeiculoAviao veiculoAviao = new VeiculoAviao
            {
                Identificacao = "PTZ-PP",
                CapacidadeDePassageiro = 350,
                Modelo = Dados.Modelos[0]
            };
            VeiculoAviao veiculoAviao2 = new VeiculoAviao
            {
                Identificacao = "APZ-AP",
                CapacidadeDePassageiro = 350,
                Modelo = Dados.Modelos[0]
            };
            VeiculoAviaoDeGuerra veiculoAviaoDeGuerra = new VeiculoAviaoDeGuerra
            {
                Identificacao = "Spirit of Florida",
                CapacidadeDePassageiro = 2,
                Modelo = Dados.Modelos[1],
            };
            VeiculoAviaoDeGuerra veiculoAviaoDeGuerra2 = new VeiculoAviaoDeGuerra
            {
                Identificacao = "Spirit of Massachuchets",
                CapacidadeDePassageiro = 2,
                Modelo = Dados.Modelos[1],
            };
            VeiculoCaminhao veiculoCaminhao = new VeiculoCaminhao
            {
                Identificacao = "TGX DSABV-887",
                Modelo = Dados.Modelos[2],
                CapacidadeDePassageiro = 1,
                QuantidadeDeEixos = 2,
                CapacidadeMaxima = 15000,
            };
            VeiculoCaminhao veiculoCaminhao2 = new VeiculoCaminhao
            {
                Identificacao = "TGX ABCYV-167",
                Modelo = Dados.Modelos[2],
                CapacidadeDePassageiro = 1,
                QuantidadeDeEixos = 2,
                CapacidadeMaxima = 15000,
            };
            VeiculoCarro veiculoCarro = new VeiculoCarro
            {
                Identificacao = "C Class DACXA-887",
                Modelo = Dados.Modelos[3],
                CapacidadeDePassageiro = 3,
                QuantidadeDePortas = 2,
            };
            VeiculoCarro veiculoCarro2 = new VeiculoCarro
            {
                Identificacao = "C Class ADAXF-173",
                Modelo = Dados.Modelos[3],
                CapacidadeDePassageiro = 3,
                QuantidadeDePortas = 2,
            };
            VeiculoMoto veiculoMoto = new VeiculoMoto
            {
                Identificacao = "Mitsubishu 650 SDFAS-187",
                Modelo = Dados.Modelos[4],
                CapacidadeDePassageiro = 3,
            };
            VeiculoMoto veiculoMoto2 = new VeiculoMoto
            {
                Identificacao = "Mitsubishu 650 KVCXH-837",
                Modelo = Dados.Modelos[4],
                CapacidadeDePassageiro = 3,
            };
            VeiculoNavio veiculoNavio = new VeiculoNavio
            {
                Identificacao = "EverGiven",
                Modelo = Dados.Modelos[5],
                CapacidadeDePassageiro = 30,
            };
            VeiculoNavio veiculoNavio2 = new VeiculoNavio
            {
                Identificacao = "Algeciras",
                Modelo = Dados.Modelos[5],
                CapacidadeDePassageiro = 35,
            };
            VeiculoNavioDeGuerra veiculoNavioDeGuerra = new VeiculoNavioDeGuerra
            {
                Identificacao = "HMS Broadsword",
                Modelo = Dados.Modelos[6],
                CapacidadeDePassageiro = 70,
            };
            VeiculoNavioDeGuerra veiculoNavioDeGuerra2 = new VeiculoNavioDeGuerra
            {
                Identificacao = "HMS Battleaxe",
                Modelo = Dados.Modelos[6],
                CapacidadeDePassageiro = 75,
            };
            VeiculoOnibus veiculoOnibus = new VeiculoOnibus
            {
                Identificacao = "T23 GFVBC-887",
                Modelo = Dados.Modelos[7],
                CapacidadeDePassageiro = 75,
                QuantidadeDeEixos = 2,
                PossuiLeito = true,
            };
            VeiculoOnibus veiculoOnibus2 = new VeiculoOnibus
            {
                Identificacao = "T23 FADCV-215",
                Modelo = Dados.Modelos[7],
                CapacidadeDePassageiro = 75,
                QuantidadeDeEixos = 2,
                PossuiLeito = true,
            };
            VeiculoTrem veiculoTrem = new VeiculoTrem
            {
                Identificacao = "GE U26C São Paulo - Santos",
                Modelo = Dados.Modelos[7],
                CapacidadeDePassageiro = 3,
                QuantidadeDeVagoes = 10
            };
            VeiculoTrem veiculoTrem2 = new VeiculoTrem
            {
                Identificacao = "GE U26C Campinas - Santos",
                Modelo = Dados.Modelos[7],
                CapacidadeDePassageiro = 3,
                QuantidadeDeVagoes = 10
            };

            Dados.AdicionarVeiculo(veiculoAviao);
            Dados.AdicionarVeiculo(veiculoAviao2);
            Dados.AdicionarVeiculo(veiculoAviaoDeGuerra);
            Dados.AdicionarVeiculo(veiculoAviaoDeGuerra2);
            Dados.AdicionarVeiculo(veiculoCaminhao);
            Dados.AdicionarVeiculo(veiculoCaminhao2);
            Dados.AdicionarVeiculo(veiculoCarro);
            Dados.AdicionarVeiculo(veiculoCarro2);
            Dados.AdicionarVeiculo(veiculoMoto);
            Dados.AdicionarVeiculo(veiculoMoto2);
            Dados.AdicionarVeiculo(veiculoNavio);
            Dados.AdicionarVeiculo(veiculoNavio2);
            Dados.AdicionarVeiculo(veiculoNavioDeGuerra);
            Dados.AdicionarVeiculo(veiculoNavioDeGuerra2);
            Dados.AdicionarVeiculo(veiculoOnibus);
            Dados.AdicionarVeiculo(veiculoOnibus2);
            Dados.AdicionarVeiculo(veiculoTrem);
            Dados.AdicionarVeiculo(veiculoTrem2);
        }
        private static void AdicionarModelos()
        {
            Modelo modeloAviao = new Modelo(1, "Regional Jet", Dados.Marcas[2], EnumTipoVeiculo.Aviao);
            Modelo modeloAviaoGuerra = new Modelo(1, "B-2 Spirit", Dados.Marcas[4], EnumTipoVeiculo.AviaoDeGuerra);
            Modelo modeloCaminhao = new Modelo(1, "TGX", Dados.Marcas[1], EnumTipoVeiculo.Caminhao);
            Modelo modeloCarro = new Modelo(1, "C Class", Dados.Marcas[0], EnumTipoVeiculo.Carro);
            Modelo modeloMoto = new Modelo(2, "650", Dados.Marcas[2], EnumTipoVeiculo.Moto);
            Modelo modeloNavio = new Modelo(1, "Navio Cargueiro", Dados.Marcas[3], EnumTipoVeiculo.Navio);
            Modelo modeloNavioDeGuerra = new Modelo(2, "Type 22", Dados.Marcas[3], EnumTipoVeiculo.NavioDeGuerra);
            Modelo modeloOnibus = new Modelo(2, "OF 1721", Dados.Marcas[0], EnumTipoVeiculo.Onibus);
            Modelo modeloTrem = new Modelo(1, "GE U26C", Dados.Marcas[5], EnumTipoVeiculo.Trem);

            Dados.AdicionarModelo(modeloAviao);
            Dados.AdicionarModelo(modeloAviaoGuerra);
            Dados.AdicionarModelo(modeloCaminhao);
            Dados.AdicionarModelo(modeloCarro);
            Dados.AdicionarModelo(modeloMoto);
            Dados.AdicionarModelo(modeloNavio);
            Dados.AdicionarModelo(modeloNavioDeGuerra);
            Dados.AdicionarModelo(modeloOnibus);
            Dados.AdicionarModelo(modeloTrem);
        }
        private static void AdicionarMarcas()
        {
            Marca marca1 = new Marca(1, "Mercedez-Bens", new List<EnumTipoVeiculo>
                                                    {EnumTipoVeiculo.Carro,
                                                     EnumTipoVeiculo.Onibus });
            Marca marca2 = new Marca(2, "MAN", new List<EnumTipoVeiculo>
                                                    {EnumTipoVeiculo.Caminhao});
            Marca marca3 = new Marca(3, "Mitsubishi", new List<EnumTipoVeiculo>
                                                    {EnumTipoVeiculo.Moto,
                                                     EnumTipoVeiculo.Carro,
                                                     EnumTipoVeiculo.Aviao});
            Marca marca4 = new Marca(4, "Yarrow Shipbuilders", new List<EnumTipoVeiculo>
                                                    {EnumTipoVeiculo.Navio,
                                                     EnumTipoVeiculo.NavioDeGuerra});
            Marca marca5 = new Marca(5, "Northrop Grumman ", new List<EnumTipoVeiculo>
                                                    {EnumTipoVeiculo.AviaoDeGuerra });
            Marca marca6 = new Marca(6, "GE Transportation", new List<EnumTipoVeiculo>
                                                    {EnumTipoVeiculo.Trem });
            Dados.AdicionarMarca(marca1);
            Dados.AdicionarMarca(marca2);
            Dados.AdicionarMarca(marca3);
            Dados.AdicionarMarca(marca4);
            Dados.AdicionarMarca(marca5);
            Dados.AdicionarMarca(marca6);
        }
        private static void AdicionaPedagios()
        {
            Pedagio pedagio1 = new Pedagio("Pedágio Via Expressa", "São Paulo");
            Dados.AdicionarPedagio(pedagio1);
            Pedagio pedagio2 = new Pedagio("Pedágio Auto Express", "Rio de Janeiro");
            Dados.AdicionarPedagio(pedagio2);
            Pedagio pedagio3 = new Pedagio("Pedágio ConectCar", "Belo Horizonte");
            Dados.AdicionarPedagio(pedagio3);
        }
        private static void DeletaArquivos()
        {
            if (File.Exists("marcas.json"))
                File.Delete("marcas.json");
            if (File.Exists("modelos.json"))
                File.Delete("modelos.json");
            if (File.Exists("pedagios.json"))
                File.Delete("pedagios.json");
            if (File.Exists("veiculos.json"))
                File.Delete("veiculos.json");

            Dados.LerMarcas();
            Dados.LerModelo();
            Dados.LerPedagio();
            Dados.LerVeiculo();
        }
    }
}
