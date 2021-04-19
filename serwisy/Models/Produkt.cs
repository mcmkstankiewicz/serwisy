using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace serwisy.Models
{
    public class Produkt
    {

        public int Id { get; set; }
        [MaxLength(30)]
        public string Maker { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(200)]
        [JsonPropertyName("Description")]
        public string Desc { get; set; }


        public override string ToString() => JsonSerializer.Serialize<Produkt>(this);



    }
}
