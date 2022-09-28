using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CA
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class CHOCDF
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class CHOCDFNet
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class CHOLE
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class Digest
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("schemaOrgTag")]
        public string SchemaOrgTag { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("hasRDI")]
        public bool HasRDI { get; set; }

        [JsonProperty("daily")]
        public double Daily { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("sub")]
        public List<Sub> Sub { get; set; }
    }

    public class ENERCKCAL
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FAMS
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FAPU
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FASAT
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FAT
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FATRN
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FE
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FIBTG
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FOLAC
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FOLDFE
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FOLFD
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class Hit
    {
        [JsonProperty("recipe")]
        public Recipe Recipe { get; set; }
    }

    public class Ingredient
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("foodCategory")]
        public string FoodCategory { get; set; }

        [JsonProperty("foodId")]
        public string FoodId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class K
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class MG
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class NA
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class NIA
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class P
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class PROCNT
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class Recipe
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("shareAs")]
        public string ShareAs { get; set; }

        [JsonProperty("yield")]
        public double Yield { get; set; }

        [JsonProperty("dietLabels")]
        public List<string> DietLabels { get; set; }

        [JsonProperty("healthLabels")]
        public List<string> HealthLabels { get; set; }

        [JsonProperty("cautions")]
        public List<string> Cautions { get; set; }

        [JsonProperty("ingredientLines")]
        public List<string> IngredientLines { get; set; }

        [JsonProperty("ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonProperty("calories")]
        public double Calories { get; set; }

        [JsonProperty("totalWeight")]
        public double TotalWeight { get; set; }

        [JsonProperty("totalTime")]
        public double TotalTime { get; set; }

        [JsonProperty("cuisineType")]
        public List<string> CuisineType { get; set; }

        [JsonProperty("mealType")]
        public List<string> MealType { get; set; }

        [JsonProperty("dishType")]
        public List<string> DishType { get; set; }

        [JsonProperty("totalNutrients")]
        public TotalNutrients TotalNutrients { get; set; }

        [JsonProperty("totalDaily")]
        public TotalDaily TotalDaily { get; set; }

        [JsonProperty("digest")]
        public List<Digest> Digest { get; set; }
    }

    public class RIBF
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class Root
    {
        [JsonProperty("q")]
        public string Q { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("hits")]
        public List<Hit> Hits { get; set; }
    }

    public class Sub
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("schemaOrgTag")]
        public string SchemaOrgTag { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("hasRDI")]
        public bool HasRDI { get; set; }

        [JsonProperty("daily")]
        public double Daily { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class SUGAR
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class SUGARAdded
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class SugarAlcohol
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class THIA
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class TOCPHA
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class TotalDaily
    {
        [JsonProperty("ENERC_KCAL")]
        public ENERCKCAL ENERCKCAL { get; set; }

        [JsonProperty("FAT")]
        public FAT FAT { get; set; }

        [JsonProperty("FASAT")]
        public FASAT FASAT { get; set; }

        [JsonProperty("CHOCDF")]
        public CHOCDF CHOCDF { get; set; }

        [JsonProperty("FIBTG")]
        public FIBTG FIBTG { get; set; }

        [JsonProperty("PROCNT")]
        public PROCNT PROCNT { get; set; }

        [JsonProperty("CHOLE")]
        public CHOLE CHOLE { get; set; }

        [JsonProperty("NA")]
        public NA NA { get; set; }

        [JsonProperty("CA")]
        public CA CA { get; set; }

        [JsonProperty("MG")]
        public MG MG { get; set; }

        [JsonProperty("K")]
        public K K { get; set; }

        [JsonProperty("FE")]
        public FE FE { get; set; }

        [JsonProperty("ZN")]
        public ZN ZN { get; set; }

        [JsonProperty("P")]
        public P P { get; set; }

        [JsonProperty("VITA_RAE")]
        public VITARAE VITARAE { get; set; }

        [JsonProperty("VITC")]
        public VITC VITC { get; set; }

        [JsonProperty("THIA")]
        public THIA THIA { get; set; }

        [JsonProperty("RIBF")]
        public RIBF RIBF { get; set; }

        [JsonProperty("NIA")]
        public NIA NIA { get; set; }

        [JsonProperty("VITB6A")]
        public VITB6A VITB6A { get; set; }

        [JsonProperty("FOLDFE")]
        public FOLDFE FOLDFE { get; set; }

        [JsonProperty("VITB12")]
        public VITB12 VITB12 { get; set; }

        [JsonProperty("VITD")]
        public VITD VITD { get; set; }

        [JsonProperty("TOCPHA")]
        public TOCPHA TOCPHA { get; set; }

        [JsonProperty("VITK1")]
        public VITK1 VITK1 { get; set; }
    }

    public class TotalNutrients
    {
        [JsonProperty("ENERC_KCAL")]
        public ENERCKCAL ENERCKCAL { get; set; }

        [JsonProperty("FAT")]
        public FAT FAT { get; set; }

        [JsonProperty("FASAT")]
        public FASAT FASAT { get; set; }

        [JsonProperty("FATRN")]
        public FATRN FATRN { get; set; }

        [JsonProperty("FAMS")]
        public FAMS FAMS { get; set; }

        [JsonProperty("FAPU")]
        public FAPU FAPU { get; set; }

        [JsonProperty("CHOCDF")]
        public CHOCDF CHOCDF { get; set; }

        [JsonProperty("CHOCDF.net")]
        public CHOCDFNet CHOCDFNet { get; set; }

        [JsonProperty("FIBTG")]
        public FIBTG FIBTG { get; set; }

        [JsonProperty("SUGAR")]
        public SUGAR SUGAR { get; set; }

        [JsonProperty("SUGAR.added")]
        public SUGARAdded SUGARAdded { get; set; }

        [JsonProperty("PROCNT")]
        public PROCNT PROCNT { get; set; }

        [JsonProperty("CHOLE")]
        public CHOLE CHOLE { get; set; }

        [JsonProperty("NA")]
        public NA NA { get; set; }

        [JsonProperty("CA")]
        public CA CA { get; set; }

        [JsonProperty("MG")]
        public MG MG { get; set; }

        [JsonProperty("K")]
        public K K { get; set; }

        [JsonProperty("FE")]
        public FE FE { get; set; }

        [JsonProperty("ZN")]
        public ZN ZN { get; set; }

        [JsonProperty("P")]
        public P P { get; set; }

        [JsonProperty("VITA_RAE")]
        public VITARAE VITARAE { get; set; }

        [JsonProperty("VITC")]
        public VITC VITC { get; set; }

        [JsonProperty("THIA")]
        public THIA THIA { get; set; }

        [JsonProperty("RIBF")]
        public RIBF RIBF { get; set; }

        [JsonProperty("NIA")]
        public NIA NIA { get; set; }

        [JsonProperty("VITB6A")]
        public VITB6A VITB6A { get; set; }

        [JsonProperty("FOLDFE")]
        public FOLDFE FOLDFE { get; set; }

        [JsonProperty("FOLFD")]
        public FOLFD FOLFD { get; set; }

        [JsonProperty("FOLAC")]
        public FOLAC FOLAC { get; set; }

        [JsonProperty("VITB12")]
        public VITB12 VITB12 { get; set; }

        [JsonProperty("VITD")]
        public VITD VITD { get; set; }

        [JsonProperty("TOCPHA")]
        public TOCPHA TOCPHA { get; set; }

        [JsonProperty("VITK1")]
        public VITK1 VITK1 { get; set; }

        [JsonProperty("Sugar.alcohol")]
        public SugarAlcohol SugarAlcohol { get; set; }

        [JsonProperty("WATER")]
        public WATER WATER { get; set; }
    }

    public class VITARAE
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class VITB12
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class VITB6A
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class VITC
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class VITD
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class VITK1
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class WATER
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class ZN
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }


}
