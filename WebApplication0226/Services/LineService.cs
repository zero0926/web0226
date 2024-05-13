using System.Drawing;
using Line.Messaging;
using Line.Messaging.Webhooks;

public class LineService : ILineService
{
    public LineService()
    {
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = null as List<ISendMessage>;

       /* if (message.Contains("現代參考"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage($"hello"),new ImageMessage("https://i.pinimg.com/564x/13/00/69/13006906dffc0691640f76b2f2f776ba.jpg",
                    "https://i.pinimg.com/564x/13/00/69/13006906dffc0691640f76b2f2f776ba.jpg",null),
                
            };
        }*/

       if (message.Contains("現代參考"))
       {
           string[] imageurl = new string[]
           {
               "https://i.pinimg.com/564x/13/00/69/13006906dffc0691640f76b2f2f776ba.jpg",
               "https://i.pinimg.com/564x/56/0d/11/560d11bacbf9e8d7a4d1a20d04b8562f.jpg",
               "https://i.pinimg.com/originals/fd/6a/0e/fd6a0efe38d4f99147aa8706b95b0f24.jpg",
           };
           var rand = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
           int index = rand.Next(imageurl.Length);

          return new List<ISendMessage>
           {
               new TextMessage($"hello"), new ImageMessage(imageurl[index], imageurl[index], null),

           };
       }

       result = new List<ISendMessage>
       {
           new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
       };
       return result;
    }

    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,string originalContentUrl,
        string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId, Image image)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a location event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
}