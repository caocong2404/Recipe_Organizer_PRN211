using Services.Service;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Models;
using System.Xml.Linq;
using Recipe_Organizer_PRN211.Recipe;

namespace Recipe_Organizer_PRN211.Authentication
{
    public partial class AddRecipe : Form
    {
        RecipeRepository _recipeRepository;
        UserRepository _userRepository;

        public AddRecipe()
        {
            _recipeRepository = new RecipeRepository();

            InitializeComponent();
        }
        public static string url = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtImport.Text = ImageToBase64(url);
            if ((txtDescription.Text.Length > 0) && (txtIngredient.Text.Length > 0) && (txtTitle.Text.Length > 0) && (txtImport.Text.Length > 0)
                && (txtDescription.Text.Trim() != "") && (txtIngredient.Text.Trim() != "") && (txtTitle.Text.Trim() != "") && (txtImport.Text.Trim() != ""))
            {
                var recipe = new Services.Models.Recipe();
                recipe.Title = txtTitle.Text.ToString();
                recipe.Description = txtDescription.Text.ToString();
                recipe.Ingredient = txtIngredient.Text.ToString();
                //txtImport.Text = ImageToBase64(url);
                //recipe.Img = txtImport.Text.ToString();
                recipe.Img = (txtImport.Text = ImageToBase64(url));
                recipe.UserId = AppContext.CurrentUser.UserId;
                recipe.Status = "Pending";


                recipe.Date = DateTime.Now;
                // txtImport.Text = ImageToBase64(url);
                _recipeRepository.Add(recipe);
            }
            else
            {
                MessageBox.Show("Error type input date", "WARNING", MessageBoxButtons.OK);

            }

        }



        private void btImport_Click(object sender, EventArgs e)
        {


            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // txtImport.Text = dlg.FileName;
                    imgImage.Image = new Bitmap(dlg.FileName);

                    url = dlg.FileName;

                    //  txtImport.Text = ImageToBase64(url);

                }
            }

        }


        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }



        //Transfer Img to base 64 
        public string ImageToBase64(string path)
        {
            // string path = "D:\SampleImage.jpg";
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form searchForm = new SearchRecipe();
            this.Hide();
            searchForm.ShowDialog(); 
        }
    }
}

