using EierfarmBl;
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
using System.Xml.Serialization;
using System.Reflection;

namespace EierfarmUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbxAnimalTypes.DataSource = GetEggProducerTypes();
        }

        private List<Type> GetEggProducerTypes()
        {
            Assembly eggFarmAssembly = Assembly.Load("EierfarmBl");

            var qIEggProdTypes = from ti in eggFarmAssembly.DefinedTypes
                                 where ti.ImplementedInterfaces.Any(ii => ii.FullName == "EierfarmBl.IEggProducer")
                                        && ti.IsAbstract == false
                                 select ti.AsType();

            return qIEggProdTypes.ToList();
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            Chicken chicken = new Chicken();

            chicken.PropertyChanged += Bird_PropertyChanged;

            cbxTiere.Items.Add(chicken);
            cbxTiere.SelectedItem = chicken;
        }

        private void Chicken_PropertyChanged(object sender, BirdEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Bird_PropertyChanged(object sender, BirdEventArgs e)
        {
            //MessageBox.Show($"Animal {sender as IEggProducer} has Property {e.ChangedProperty} changed.");
            pgdTier.SelectedObject = sender as IEggProducer;
        }

        private void btnChicken_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnDuck_Click(object sender, EventArgs e)
        {
            Duck duck = new Duck();
            duck.PropertyChanged += Bird_PropertyChanged;

            cbxTiere.Items.Add(duck);
            cbxTiere.SelectedItem = duck;
        }

        private void btnPlatibus_Click(object sender, EventArgs e)
        {
            Platibus platibus = new Platibus();

            cbxTiere.Items.Add(platibus);
            cbxTiere.SelectedItem = platibus;
        }

        private void cbxTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            pgdTier.SelectedObject = cbxTiere.SelectedItem;
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            IEggProducer animal = pgdTier.SelectedObject as IEggProducer;
            if (animal != null)
            {
                animal.Eat();
            }
        }

        private void btnLayEgg_Click(object sender, EventArgs e)
        {
            System.Nullable<int> a = null;
            int? a2 = null;

            //int b = (a.HasValue ? a.Value : -1);
            int b = (a ?? -1) + (a2 ?? -99);

            (pgdTier.SelectedObject as IEggProducer)?.LayEgg();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            // Benutzer nach Speicherort fragen
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                RestoreDirectory = true,
                Filter = "EggProducer|*.epp|All|*.*",
                FilterIndex = 0
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                IEggProducer tier = pgdTier.SelectedObject as IEggProducer;

                if (tier != null)
                {

                    IDisposableImplementer o = null;
                    try
                    {
                        o = new IDisposableImplementer();
                        // Tier dort speichern
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            //Type tpChicken = Type.GetType("EierfarmBl.Chicken");

                            // Jede konkrete Instanz kennt ihren konkreten Typ (aus GetType())
                            XmlSerializer serializer = new XmlSerializer(typeof(IEggProducer));
                            serializer.Serialize(writer, tier);
                        }
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                    finally
                    {
                        // NICHT VERGESSEN, wenn kein using verwendet!
                        o?.Dispose();
                    }

                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Type newTierType = cbxAnimalTypes.SelectedItem as Type;
            if (newTierType != null)
            {
                Assembly eggFarmAssembly = Assembly.Load("EierfarmBl");

                IEggProducer tier = eggFarmAssembly.CreateInstance(newTierType.FullName) as IEggProducer;
                if (tier != null)
                {
                    cbxTiere.Items.Add(tier);
                    cbxTiere.SelectedItem = tier;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class IDisposableImplementer : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
