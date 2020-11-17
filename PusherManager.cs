using System;
using System.Threading.Tasks;
using PusherClient;
using UnityEngine;

public class PusherManager : MonoBehaviour
{
    public static PusherManager instance = null;
    private Pusher pusher;
    private Channel channel;

    async Task Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        await InitialisePusher();
    }

    private async Task InitialisePusher()
    {

        if (pusher == null)
        {
            pusher = new Pusher("c57ebfe8294971c367d0", new PusherOptions()
            {
                Cluster = "mt1",
                Encrypted = true
            });

            pusher.Error += OnPusherOnError;
            pusher.ConnectionStateChanged += PusherOnConnectionStateChanged;
            pusher.Connected += PusherOnConnected;
            channel = await pusher.SubscribeAsync("my-channel");
            channel.Subscribed += OnChannelOnSubscribed;
            await pusher.ConnectAsync();
        }
    }

    private void PusherOnConnected(object sender)
    {
        Debug.Log("Connected");
        channel.Bind("my-event", (dynamic data) =>
        {
            Debug.Log("my-event received");
        });
    }

    private void PusherOnConnectionStateChanged(object sender, ConnectionState state)
    {
        Debug.Log("Connection state changed");
    }

    private void OnPusherOnError(object s, PusherException e)
    {
        Debug.Log("Errored");
    }

    private void OnChannelOnSubscribed(object s)
    {
        Debug.Log("Subscribed");
    }

    async Task OnApplicationQuit()
    {
        if (pusher != null)
        {
            await pusher.DisconnectAsync();
        }
    }
}
