using Newtonsoft.Json;

namespace DocumentParser.Api.Contracts.Data
{
    public class Columns
    {
        [JsonProperty("field-gpios")]
        public List<string> FieldGpios { get; set; }

        [JsonProperty("field-nominal-vdd")]
        public List<string> FieldNominalVdd { get; set; }

        [JsonProperty("field-cnt-dly-max-")]
        public List<string> FieldCntDlyMax { get; set; }

        [JsonProperty("field-luts-max-")]
        public List<string> FieldLutsMax { get; set; }

        [JsonProperty("field-dff-max-")]
        public List<string> FieldDffMax { get; set; }

        [JsonProperty("field-pipe-delay")]
        public List<string> FieldPipeDelay { get; set; }

        [JsonProperty("field--of-programable-delays")]
        public List<string> FieldOfProgramableDelays { get; set; }

        [JsonProperty("field-oscillator-type")]
        public List<string> FieldOscillatorType { get; set; }

        [JsonProperty("field-memory-type")]
        public List<string> FieldMemoryType { get; set; }

        [JsonProperty("field-pkg-dimensions")]
        public List<string> FieldPkgDimensions { get; set; }

        [JsonProperty("field-type")]
        public List<string> FieldType { get; set; }

        [JsonProperty("field-lead-cnt")]
        public List<string> FieldLeadCnt { get; set; }

        [JsonProperty("field-acmp-analog-comparator")]
        public List<string> FieldAcmpAnalogComparator { get; set; }

        [JsonProperty("field-special-features")]
        public List<string> FieldSpecialFeatures { get; set; }

        [JsonProperty("field-dcmp-pwm")]
        public List<string> FieldDcmpPwm { get; set; }

        [JsonProperty("field-interface")]
        public List<string> FieldInterface { get; set; }

        [JsonProperty("field-temperature-sensor-ch-")]
        public List<string> FieldTemperatureSensorCh { get; set; }
    }

    public class Filters
    {
        [JsonProperty("columns")]
        public Columns Columns { get; set; }

        [JsonProperty("rows")]
        public Rows Rows { get; set; }
    }

    public class Nid1563621
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563636
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563641
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563651
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563661
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563676
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563691
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563701
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563706
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563711
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563726
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563731
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563741
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563751
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Nid1563756
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Root
    {
        [JsonProperty("rows")]
        public List<string> Rows { get; set; }

        [JsonProperty("filters")]
        public Filters Filters { get; set; }
    }

    public class Rows
    {
        [JsonProperty("nid-1563661")]
        public Nid1563661 Nid1563661 { get; set; }

        [JsonProperty("nid-1563651")]
        public Nid1563651 Nid1563651 { get; set; }

        [JsonProperty("nid-1563621")]
        public Nid1563621 Nid1563621 { get; set; }

        [JsonProperty("nid-1563636")]
        public Nid1563636 Nid1563636 { get; set; }

        [JsonProperty("nid-1563726")]
        public Nid1563726 Nid1563726 { get; set; }

        [JsonProperty("nid-1563731")]
        public Nid1563731 Nid1563731 { get; set; }

        [JsonProperty("nid-1563641")]
        public Nid1563641 Nid1563641 { get; set; }

        [JsonProperty("nid-1563676")]
        public Nid1563676 Nid1563676 { get; set; }

        [JsonProperty("nid-1563691")]
        public Nid1563691 Nid1563691 { get; set; }

        [JsonProperty("nid-1563706")]
        public Nid1563706 Nid1563706 { get; set; }

        [JsonProperty("nid-1563711")]
        public Nid1563711 Nid1563711 { get; set; }

        [JsonProperty("nid-1563741")]
        public Nid1563741 Nid1563741 { get; set; }

        [JsonProperty("nid-1563701")]
        public Nid1563701 Nid1563701 { get; set; }

        [JsonProperty("nid-1563751")]
        public Nid1563751 Nid1563751 { get; set; }

        [JsonProperty("nid-1563756")]
        public Nid1563756 Nid1563756 { get; set; }
    }

    public class Values
    {
        [JsonProperty("product-title")]
        public List<string> ProductTitle { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("field-special-features")]
        public List<object> FieldSpecialFeatures { get; set; }

        [JsonProperty("field-gpios")]
        public List<string> FieldGpios { get; set; }

        [JsonProperty("field-nominal-vdd")]
        public List<string> FieldNominalVdd { get; set; }

        [JsonProperty("field-vdd2")]
        public List<object> FieldVdd2 { get; set; }

        [JsonProperty("field-acmp-analog-comparator")]
        public List<object> FieldAcmpAnalogComparator { get; set; }

        [JsonProperty("field-dcmp-pwm")]
        public List<object> FieldDcmpPwm { get; set; }

        [JsonProperty("field-cnt-dly-max-")]
        public List<string> FieldCntDlyMax { get; set; }

        [JsonProperty("field-luts-max-")]
        public List<string> FieldLutsMax { get; set; }

        [JsonProperty("field-dff-max-")]
        public List<string> FieldDffMax { get; set; }

        [JsonProperty("field-pipe-delay")]
        public List<string> FieldPipeDelay { get; set; }

        [JsonProperty("field--of-programable-delays")]
        public List<string> FieldOfProgramableDelays { get; set; }

        [JsonProperty("field-oscillator-type")]
        public List<string> FieldOscillatorType { get; set; }

        [JsonProperty("field-temperature-sensor-ch-")]
        public List<object> FieldTemperatureSensorCh { get; set; }

        [JsonProperty("field-interface")]
        public List<object> FieldInterface { get; set; }

        [JsonProperty("field-memory-type")]
        public List<string> FieldMemoryType { get; set; }

        [JsonProperty("field-pkg-dimensions")]
        public List<string> FieldPkgDimensions { get; set; }

        [JsonProperty("field-type")]
        public List<string> FieldType { get; set; }

        [JsonProperty("field-lead-cnt")]
        public List<string> FieldLeadCnt { get; set; }
    }
}
