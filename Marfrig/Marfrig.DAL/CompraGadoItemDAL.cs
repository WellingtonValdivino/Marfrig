using Marfrig.Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marfrig.DAL
{
    public class CompraGadoItemDAL
    {
        //public async Task<DataGridView> GetAllCompraGadoItem(string URL)
        //{
        //    DataGridView dtgCompraGadoItem = new DataGridView();

        //    return (DataGridView)(dtgCompraGadoItem.DataSource = obj);
        //}

        //private async Task<IEnumerable<CompraGadoItem>> CompraGadoItemDA()
        //{
        //    string url = ConfigurationManager.AppSettings["Marfrig"];

        //    using (var client = new HttpClient())
        //    {
        //        using (var response = await client.GetAsync(url))
        //        {

        //            if (response.IsSuccessStatusCode)
        //            {
        //                //clienteUri = response.Headers.Location;
        //                var ProdutoJsonString = await response.Content.ReadAsStringAsync();
        //                var obj = JsonConvert.DeserializeObject<CompraGadoItem[]>(ProdutoJsonString).ToList();

        //                //var teste = obj[1].Quantidade;

        //                //if (teste == 150)
        //                //{
        //                //    MessageBox.Show("Foi ........");
        //                //}

        //                return obj;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
        //            }
        //        }
        //    }
        //}
    }
}
