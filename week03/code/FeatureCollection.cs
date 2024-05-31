using System.Text.Json.Serialization;

public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

public class Feature {
    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }
}

public class Properties {
    [JsonPropertyName("mag")]
    public double? Mag { get; set; }

    [JsonPropertyName("place")]
    public string Place { get; set; }
}