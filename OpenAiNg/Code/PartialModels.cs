﻿using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using OpenAiNg.Images;

namespace OpenAiNg.Code;

public class Ref<T>
{
    public T? Ptr { get; set; }
}

public class StreamResponse
{
    public Stream Stream { get; set; }
    public ApiResultBase Headers { get; set; }
    public HttpResponseMessage Response { get; set; }
}

/// <summary>
/// Represents a chat image
/// </summary>
public class ChatImage
{
    /// <summary>
    /// Publicly available URL to the image or base64 encoded content
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }
    /// <summary>
    /// Publicly available URL to the image or base64 encoded content
    /// </summary>
    [JsonProperty("detail")]
    public ImageDetail? Detail { get; set; }

    /// <summary>
    /// Creates a new chat image
    /// </summary>
    /// <param name="content">Publicly available URL to the image or base64 encoded content</param>
    public ChatImage(string content)
    {
        Url = content;
    }
    
    /// <summary>
    /// Creates a new chat image
    /// </summary>
    /// <param name="content">Publicly available URL to the image or base64 encoded content</param>
    /// <param name="detail">The detail level to use, defaults to <see cref="ImageDetail.Auto"/></param>
    public ChatImage(string content, ImageDetail? detail)
    {
        Url = content;
        Detail = detail;
    }
}