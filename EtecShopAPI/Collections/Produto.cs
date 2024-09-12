using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace EtecShopAPI.Collections;

[Table("produtos")]
[BsonIgnoreExtraElements]
public class Produto
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }
    
    [BsonElement("nome")]
    [JsonPropertyName("Nome")]
    public string Nome { get; set; }

    [BsonElement("descricao")]
    [JsonPropertyName("Descrição")]
    public string Descricao { get; set; }

    [BsonElement("preco")]
    [JsonPropertyName("Preço")]
    public string Preco { get; set; }

    [BsonElement("precoDesconto")]
    public string PrecoDesconto { get; set; }

    [BsonElement("categorias")]
    public List<string> Categorias { get; set; }

    [BsonElement("tags")]
    public List<string> Tags { get; set; }

    [BsonElement("marca")]
    public string Marcas { get; set; }

    [BsonElement("estoque")]
    public int Estoque { get; set; }

    [BsonElement("ativo")]
    public bool Ativo { get; set; } 
}
