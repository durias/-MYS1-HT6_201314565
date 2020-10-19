using SimioAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MYS1_HT6_201314565
{
    class _201314565
    {
        private ISimioProject proyectoApi;
        private string rutabase = "[MYS1]ModeloBase_201314565.spfx";
        private string rutafinal = "[MYS1]ModeloFinal_201314565.spfx";
        private string[] warnings;
        private IModel model;
        private IIntelligentObjects intelligentObjects;

        public _201314565()
        {
            proyectoApi = SimioProjectFactory.LoadProject(rutabase, out warnings);
            model = proyectoApi.Models[1];
            intelligentObjects = model.Facility.IntelligentObjects;
        }

        public void construir_Modelo()
        {

            crear_elementos_modelo();
            SimioProjectFactory.SaveProject(proyectoApi, rutafinal, out warnings);
        }

        public void crear_elementos_modelo()
        {
            crear_carnet();
            crear_nombre();
        }

        public void crear_carnet() {
            matriz_vertices(true, true, false, true, true, false, true, "d1", 0, 0);     //2
            matriz_vertices(true, true, true, true, true, true, false, "d2", 15, 0);     //0
            matriz_vertices(false, true, true, false, false, false, false, "d3", 25, 0); //1
            matriz_vertices(true, true, true, true, false, false, true, "d4", 45, 0);    //3
            matriz_vertices(false, true, true, false, false, false, false, "d5", 55, 0); //1
            matriz_vertices(false, true, true, false, false, true, true, "d6", 75, 0);   //4
            matriz_vertices(true, false, true, true, false, true, true, "d7", 90, 0);    //5
            matriz_vertices(true, false, true, true, true, true, true, "d8", 105, 0);    //6
            matriz_vertices(true, false, true, true, false, true, true, "d9", 120, 0);   //5
        }

        public void crear_nombre() {
            //D
            createTransferNode("TN1",0,30);
            createTransferNode("TN2", 7, 30);
            createTransferNode("TN3", 10, 33);
            createTransferNode("TN4", 10, 38);
            createTransferNode("TN5", 7, 40);
            createTransferNode("TN6", 0, 40);
            createPath(get_nodo("TN1"), get_nodo("TN2"));
            createPath(get_nodo("TN2"), get_nodo("TN3"));
            createPath(get_nodo("TN4"), get_nodo("TN5"));
            createPath(get_nodo("TN5"), get_nodo("TN6"));
            createPath(get_nodo("TN6"), get_nodo("TN1"));
            //A
            createTransferNode("TN7", 15, 30);
            createTransferNode("TN8", 25, 30);
            createTransferNode("TN9", 25, 35);
            createTransferNode("TN10", 25, 40);
            createTransferNode("TN11", 15, 40);
            createTransferNode("TN12", 15, 35);
            createPath(get_nodo("TN7"), get_nodo("TN8"));
            createPath(get_nodo("TN8"), get_nodo("TN9"));
            createPath(get_nodo("TN9"), get_nodo("TN10"));
            createPath(get_nodo("TN11"), get_nodo("TN12"));
            createPath(get_nodo("TN12"), get_nodo("TN7"));
            createPath(get_nodo("TN12"), get_nodo("TN9"));
            //N
            createTransferNode("TN13", 30, 40);
            createTransferNode("TN14", 30, 30);
            createTransferNode("TN15", 40, 40);
            createTransferNode("TN16", 40, 30);
            createPath(get_nodo("TN13"), get_nodo("TN14"));
            createPath(get_nodo("TN14"), get_nodo("TN15"));
            createPath(get_nodo("TN15"), get_nodo("TN16"));
            //I
            createTransferNode("TN17", 45, 30);
            createTransferNode("TN18", 50, 30);
            createTransferNode("TN19", 55, 30);
            createTransferNode("TN20", 45, 40);
            createTransferNode("TN21", 50, 40);
            createTransferNode("TN22", 55, 40);
            createPath(get_nodo("TN17"), get_nodo("TN18"));
            createPath(get_nodo("TN18"), get_nodo("TN19"));
            createPath(get_nodo("TN20"), get_nodo("TN21"));
            createPath(get_nodo("TN21"), get_nodo("TN22"));
            createPath(get_nodo("TN18"), get_nodo("TN21"));
            //L
            createTransferNode("TN23", 60, 30);
            createTransferNode("TN24", 60, 40);
            createTransferNode("TN25", 70, 40);
            createPath(get_nodo("TN23"), get_nodo("TN24"));
            createPath(get_nodo("TN24"), get_nodo("TN25"));
            //O
            createTransferNode("TN26", 75, 30);
            createTransferNode("TN27", 85, 30);
            createTransferNode("TN28", 85, 40);
            createTransferNode("TN29", 75, 40);
            createPath(get_nodo("TN26"), get_nodo("TN27"));
            createPath(get_nodo("TN27"), get_nodo("TN28"));
            createPath(get_nodo("TN28"), get_nodo("TN29"));
            createPath(get_nodo("TN29"), get_nodo("TN26"));


            //U
            createTransferNode("TN30", 100, 30);
            createTransferNode("TN31", 100, 40);
            createTransferNode("TN32", 110, 40);
            createTransferNode("TN33", 110, 30);
            createPath(get_nodo("TN30"), get_nodo("TN31"));
            createPath(get_nodo("TN31"), get_nodo("TN32"));
            createPath(get_nodo("TN32"), get_nodo("TN33"));
            createPath(get_nodo("TN32"), get_nodo("TN33"));
            //R
            createTransferNode("TN34", 115, 40);
            createTransferNode("TN35", 115, 30);
            createTransferNode("TN36", 125, 30);
            createTransferNode("TN37", 125, 35);
            createTransferNode("TN38", 115, 35);
            createTransferNode("TN39", 125, 40);
            createPath(get_nodo("TN34"), get_nodo("TN35"));
            createPath(get_nodo("TN35"), get_nodo("TN36"));
            createPath(get_nodo("TN36"), get_nodo("TN37"));
            createPath(get_nodo("TN37"), get_nodo("TN38"));
            createPath(get_nodo("TN38"), get_nodo("TN39"));
            //I
            createTransferNode("TN40", 130, 30);
            createTransferNode("TN41", 135, 30);
            createTransferNode("TN42", 140, 30);
            createTransferNode("TN43", 130, 40);
            createTransferNode("TN44", 135, 40);
            createTransferNode("TN45", 140, 40);
            createPath(get_nodo("TN40"), get_nodo("TN41"));
            createPath(get_nodo("TN41"), get_nodo("TN42"));
            createPath(get_nodo("TN41"), get_nodo("TN44"));
            createPath(get_nodo("TN43"), get_nodo("TN44"));
            createPath(get_nodo("TN44"), get_nodo("TN45"));
            //A
            createTransferNode("TN46", 145, 30);
            createTransferNode("TN47", 155, 30);
            createTransferNode("TN48", 155, 35);
            createTransferNode("TN49", 155, 40);
            createTransferNode("TN50", 145, 40);
            createTransferNode("TN51", 145, 35);
            createPath(get_nodo("TN46"), get_nodo("TN47"));
            createPath(get_nodo("TN47"), get_nodo("TN48"));
            createPath(get_nodo("TN48"), get_nodo("TN49"));
            createPath(get_nodo("TN50"), get_nodo("TN51"));
            createPath(get_nodo("TN51"), get_nodo("TN46"));
            createPath(get_nodo("TN51"), get_nodo("TN48"));
            //S
            createTransferNode("TN52", 170, 30);
            createTransferNode("TN53", 160, 30);
            createTransferNode("TN54", 160, 35);
            createTransferNode("TN55", 170, 35);
            createTransferNode("TN56", 170, 40);
            createTransferNode("TN57", 160, 40);
            createPath(get_nodo("TN52"), get_nodo("TN53"));
            createPath(get_nodo("TN53"), get_nodo("TN54"));
            createPath(get_nodo("TN54"), get_nodo("TN55"));
            createPath(get_nodo("TN55"), get_nodo("TN56"));
            createPath(get_nodo("TN56"), get_nodo("TN57"));
        }

        public void matriz_vertices(Boolean a, Boolean b, Boolean c, Boolean d, Boolean e, Boolean f, Boolean g, string id_unico, int x, int y)
        {
            Boolean v1 = false;
            Boolean v2 = false;
            Boolean v3 = false;
            Boolean v4 = false;
            Boolean v5 = false;
            Boolean v6 = false;

            if (a)
            {
                if (!v1)
                {
                    createTransferNode("V1_" + id_unico, x, y);
                    v1 = true;
                }
                if (!v2)
                {
                    createTransferNode("V2_" + id_unico, x + 10, y);
                    v2 = true;
                }
                createPath(get_nodo("V1_" + id_unico), get_nodo("V2_" + id_unico));
            }
            if (b)
            {
                if (!v2)
                {
                    createTransferNode("V2_" + id_unico, x + 10, y);
                    v2 = true;
                }
                if (!v3)
                {
                    createTransferNode("V3_" + id_unico, x + 10, y + 10);
                    v3 = true;
                }
                createPath(get_nodo("V2_" + id_unico), get_nodo("V3_" + id_unico));
            }
            if (c)
            {
                if (!v3)
                {
                    createTransferNode("V3_" + id_unico, x + 10, y + 10);
                    v3 = true;
                }
                if (!v4)
                {
                    createTransferNode("V4_" + id_unico, x + 10, y + 20);
                    v4 = true;
                }
                createPath(get_nodo("V3_" + id_unico), get_nodo("V4_" + id_unico));
            }
            if (d)
            {
                if (!v4)
                {
                    createTransferNode("V4_" + id_unico, x + 10, y + 20);
                    v4 = true;
                }
                if (!v5)
                {
                    createTransferNode("V5_" + id_unico, x, y + 20);
                    v5 = true;
                }
                createPath(get_nodo("V4_" + id_unico), get_nodo("V5_" + id_unico));
            }
            if (e)
            {
                if (!v5)
                {
                    createTransferNode("V5_" + id_unico, x, y + 20);
                    v5 = true;
                }
                if (!v6)
                {
                    createTransferNode("V6_" + id_unico, x, y + 10);
                    v6 = true;
                }
                createPath(get_nodo("V5_" + id_unico), get_nodo("V6_" + id_unico));
            }
            if (f)
            {
                if (!v6)
                {
                    createTransferNode("V6_" + id_unico, x, y + 10);
                    v6 = true;
                }
                if (!v1)
                {
                    createTransferNode("V1_" + id_unico, x, y);
                    v1 = true;
                }
                createPath(get_nodo("V6_" + id_unico), get_nodo("V1_" + id_unico));
            }
            if (g)
            {
                if (!v6)
                {
                    createTransferNode("V6_" + id_unico, x, y + 10);
                    v6 = true;
                }
                if (!v3)
                {
                    createTransferNode("V3_" + id_unico, x + 10, y + 10);
                    v3 = true;
                }
                createPath(get_nodo("V6_" + id_unico), get_nodo("V3_" + id_unico));
            }



        }

        //--------------- Métodos para creación de obejtos diversos --------------------------------

        public void createTransferNode(string nombre, int x, int y)
        {
            intelligentObjects.CreateObject("TransferNode", new FacilityLocation(x, 0, y));
            model.Facility.IntelligentObjects["TransferNode1"].ObjectName = nombre;
        }

        public void createPath(INodeObject nodo1, INodeObject nodo2)
        {
            this.createLink("Path", nodo1, nodo2);
        }


        public INodeObject get_nodo(String name)
        {
            return (INodeObject)model.Facility.IntelligentObjects[name];
        }

        public void createLink(String type, INodeObject nodo1, INodeObject nodo2)
        {
            intelligentObjects.CreateLink(type, nodo1, nodo2, null);
        }

    }
}
