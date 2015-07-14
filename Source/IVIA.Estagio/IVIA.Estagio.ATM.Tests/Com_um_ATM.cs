using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IVIA.Estagio.ATM;

namespace IVIA.Estagio.ATM.Tests
{
    [TestClass]
    public class Com_um_ATM
    {
        Atm _atm;
        Atm _atmCarregado;
        CargaAtm _cargaAtm;

        [TestInitialize]
        public void AtmSetup()
        {
            _atm = new Atm();
            _atmCarregado = new Atm();
            _cargaAtm = new CargaAtm(_atmCarregado);
            _cargaAtm.Adicionar(5, ValorNota.Cem);
            _cargaAtm.Adicionar(10, ValorNota.Cinquenta);
            _cargaAtm.Adicionar(25, ValorNota.Vinte);
            _cargaAtm.Adicionar(50, ValorNota.Dez);
            _cargaAtm.Adicionar(100, ValorNota.Cinco);
            _cargaAtm.Adicionar(250, ValorNota.Dois);
        }

        [TestMethod]
        public void Quando_iniciado_o_valor_total_em_dinheiro_eh_zero()
        {
            Assert.AreEqual(0, _atm.TotalEmDinheiro);
        }

        [TestMethod]
        public void Quando_iniciado_nao_tenho_notas_disponiveis_de_nenhum_valor()
        {
            int quantidade;

            _atm.NotasDisponiveis.TryGetValue(ValorNota.Dois, out quantidade);
            Assert.AreEqual(0, quantidade);

            _atm.NotasDisponiveis.TryGetValue(ValorNota.Cinco, out quantidade);
            Assert.AreEqual(0, quantidade);

            _atm.NotasDisponiveis.TryGetValue(ValorNota.Dez, out quantidade);
            Assert.AreEqual(0, quantidade);

            _atm.NotasDisponiveis.TryGetValue(ValorNota.Vinte, out quantidade);
            Assert.AreEqual(0, quantidade);

            _atm.NotasDisponiveis.TryGetValue(ValorNota.Cinquenta, out quantidade);
            Assert.AreEqual(0, quantidade);

            _atm.NotasDisponiveis.TryGetValue(ValorNota.Cem, out quantidade);
            Assert.AreEqual(0, quantidade);
           
        }

        [TestMethod]
        public void Quando_carrego_5_notas_de_100_total_em_dinheiro_eh_500()
        {
            var cargaAtm = new CargaAtm(_atm);
            cargaAtm.Adicionar(5, ValorNota.Cem);
            Assert.AreEqual(500, _atm.TotalEmDinheiro);
        }

        [TestMethod]
        public void Nao_Posso_Sacar_Dinheiro_Quando_Zerado()
        {
            bool saqueOk = _atm.Sacar(10);
            Assert.IsFalse(saqueOk);
        }

        [TestMethod]
        public void Quando_Carregado_Contem_3000_Reais()
        {
            Assert.AreEqual(3000, _atmCarregado.TotalEmDinheiro);
        }

        [TestMethod]
        public void Posso_Sacar_Dinheiro_Quando_Carregado()
        {
            bool saqueOk = _atmCarregado.Sacar(10);
            Assert.IsTrue(saqueOk);
        }

    }
}
