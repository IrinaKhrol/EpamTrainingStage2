using Newtonsoft.Json;

namespace Core
{
    public class JsonReader
    {
        public FormData ReadFormData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist.", filePath);
            }
            try
            {
                string json = File.ReadAllText(filePath);

                FormData formData = JsonConvert.DeserializeObject<FormData>(json);

                return formData;
            }
            catch (JsonException ex)
            {
                throw new JsonException("Error deserializing JSON.", ex);
            }
        }
    }
}

