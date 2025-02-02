namespace Jaket.Content;

/// <summary> All packet types. Will replenish over time. </summary>
public enum PacketType
{
    /// <summary> Data of an entity: player, enemy, item and etc. </summary>
    Snapshot,
    /// <summary> Initializes a loading of the level requested by the host. </summary>
    LoadLevel,
    /// <summary> Hey Client, could you leave the lobby please? The host asks you to leave the lobby because you were kicked... Cheers~ :heart: </summary>
    Kick,

    /// <summary> Client requests enemy spawn. </summary>
    SpawnEntity,
    /// <summary> Server or client requests bullet spawn. </summary>
    SpawnBullet,
    /// <summary> Data on the damage dealt to an entity. </summary>
    DamageEntity,
    /// <summary> Request from a host to kill an entity or from a client to destroy a bullet. </summary>
    KillEntity,

    /// <summary> Player changed their style: the color of weapons or clothes. </summary>
    Style,
    /// <summary> Player punched, this needs to be visually displayed. </summary>
    Punch,
    /// <summary> Player pointed to some point in space. </summary>
    Point,

    /// <summary> Need to activate a certain object. It can be anything, because there are a lot of different stuff in the game. </summary>
    ActivateObject,
    /// <summary> Any action with the cinema, like starting a video, pausing or rewinding. </summary>
    CinemaAction,
    /// <summary> Any action with CyberGrind, like pattern and wave. </summary>
    CyberGrindAction
}
