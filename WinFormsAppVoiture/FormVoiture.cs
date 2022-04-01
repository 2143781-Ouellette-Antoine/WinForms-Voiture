using BibliothequeClasse;
using System.Text;

namespace WinFormsAppVoiture
{
    public partial class FormVoiture : Form
    {
        //Une liste de toutes les voitures qui existent.
        //Elles seront affichees dans le comboBox.
        private List<Voiture> listeVoitures = new List<Voiture>();
        //La voiture actuellement selectionee
        private Voiture ?selectedVoiture;

        public FormVoiture()
        {
            InitializeComponent();
        }

        private void ButtonCreerVoiture_Click(object sender, EventArgs e)
        {
            //Valider les champs
            bool CreerValide = ValiderCreer();
            if (!CreerValide)
                return;

            //Soumettre la voiture
            SoumettreVoiture();
        }

        private void UpdaterInformations(Voiture voiture)
        {
            //Reservoir Gauge
            informationsGaugeReservoirGrise.Height = (int)(120 - (voiture.Reservoir * 120/100));
            //Reservoir Pourcentage
            labelInformationsPourcentageReservoir.Text = voiture.Reservoir.ToString() + "%";
            //Nombre Km restant
            labelInformationsNbrKmRestant.Text = voiture.NombreKmDepuisDerniereRecharge.ToString() + " km";
            //Plaque
            textBoxInformationsPlaque.Text = voiture.Plaque.ToString();
            //Poid
            textBoxInformationsPoid.Text = voiture.Poid.ToString();
            //Odometre
            textBoxInformationsOdometre.Text = voiture.Odometre.ToString();
            //Titre section
            titreSectionInformations.Text = "Informations sur " + voiture.Nom;
        }

        private void ButtonUtiliserAvancer_Click(object sender, EventArgs e)
        {
            //Sanity Check
            if (selectedVoiture is null)
            {
                MessageBox.Show("Impossible d'avancer: aucune voiture selectionnee.", "Impossible!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedVoiture.Reservoir == 0)
                MessageBox.Show("Impossible d'avancer: le réservoir est vide.", "Impossible!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            uint pourcentageEnleve = selectedVoiture.Avancer((uint)numericUpDownUtiliserKmAAvancer.Value);
            UpdaterInformations(selectedVoiture);
        }

        private void ButtonUtiliserFairePleinEssence_Click(object sender, EventArgs e)
        {
            //Sanity Check
            if (selectedVoiture is null)
            {
                MessageBox.Show("Impossible de faire le plein: aucune voiture selectionnee.", "Impossible!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedVoiture.Recharger();
            UpdaterInformations(selectedVoiture);
        }

        private void ComboBoxUtiliserVoiture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxUtiliserVoiture.SelectedIndex != -1)
            { 
                //selectedVoiture = voiture selectionnee dans le ComboBox
                selectedVoiture = (Voiture?)comboBoxUtiliserVoiture.SelectedValue;
                UpdaterInformations(selectedVoiture);
            }
        }

        private bool ValiderCreer()
        {
            //Stringbuilder message d'erreur
            StringBuilder strbld = new StringBuilder();

            bool valide = true;
            //Validation Nom
            if (string.IsNullOrEmpty(textBoxCreerNom.Text))
            {
                strbld.AppendLine("Le champ Nom ne peut pas etre vide.");
                valide = false;
            }
            //Validation Plaque
            if (string.IsNullOrEmpty(textBoxCreerPlaque.Text))
            {
                strbld.AppendLine("Le champ Plaque ne peut pas etre vide.");
                valide = false;
            }
            //Validation Poid
            if (string.IsNullOrEmpty(textBoxCreerPoid.Text))
            {
                strbld.AppendLine("Le champ Poid ne peut pas etre vide.");
                valide = false;
            }
            else if (!uint.TryParse(textBoxCreerPoid.Text, out uint tempTryParse))
            {
                strbld.AppendLine("Le Poid doit etre un nombre positif.");
                valide = false;
            }

            if (!valide)
                MessageBox.Show(strbld.ToString(), "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return valide;
        }

        private void SoumettreVoiture()
        {
            //Creer et ajouter la voiture dans la liste
            uint.TryParse(textBoxCreerPoid.Text, out uint poidCree);
            Voiture voitureCree = new Voiture(textBoxCreerNom.Text, textBoxCreerPlaque.Text, poidCree);
            listeVoitures.Add(voitureCree);//La liste est Binde avec le ComboBox

            //ReBind listeVoitures as DataSource of the ComboBox.
            comboBoxUtiliserVoiture.DataSource = null;
            comboBoxUtiliserVoiture.DataSource = listeVoitures;
            comboBoxUtiliserVoiture.DisplayMember = "Nom";

            //Changer la variable selectedVoiture
            selectedVoiture = voitureCree;
            //Faire le focus de selection sur la bonne voiture de la liste
            comboBoxUtiliserVoiture.SelectedItem = voitureCree;

            //Clear fields
            textBoxCreerNom.Clear();
            textBoxCreerPlaque.Clear();
            textBoxCreerPoid.Clear();
        }

    }
}