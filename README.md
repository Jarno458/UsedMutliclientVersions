# Usage

Change the Uri and Slotname in program.cs on line 13

Starting the it will connect to an Archipelago server, and read the value of of the data storage key `".NetUsedVersions"`
The data storage key is filled by clients using the [Archipelago.MultiClient.Net]() library.
For best effect, use it on big multiworlds where a lot of different games connect, such as 1000+ player community async run over at Archipelago discord

# Output

the output will look something like this

```
Used .Net Versions:
A Short Hike: [NETSTANDARD2_0] (5.0.6.0)
Blasphemous: [NET35] (5.0.4.0)
Celeste 64: [NET6_0] (5.0.6.0)
DLCQuest: [NET45] (5.0.6.0)
Hollow Knight: [NET45] (5.0.6.0)
Hylics 2: [NET35] (5.0.6.0, 6.0.0.0)
Muse Dash: [NET6_0] (5.0.6.0, 6.0.0.0, 6.0.1.0)
Overcooked! 2: [NET35] (5.0.6.0)
Raft: [NET35] (5.0.3.0, 6.0.0.0)
Risk of Rain 2: [NETSTANDARD2_0] (5.0.6.0, 6.0.0.0)
Rogue Legacy: [NET45] (5.0.6.0)
Shivers: [NET6_0] (5.0.5.0, 5.0.6.0, 6.0.1.0)
Stardew Valley: [NETSTANDARD2_0, NET6_0] (5.0.6.0, 6.0.0.0)
Subnautica: [NETSTANDARD2_0] (5.0.6.0, 5.0.4.0, 6.0.1.0)
The Messenger: [NET35] (5.0.6.0)
Timespinner: [NET40, NET45] (5.0.5.0, 5.0.6.0, 6.0.0.0, 6.0.1.0)
TUNIC: [NET45] (5.0.5.0, 6.0.0.0, 6.0.1.0)
Unknown: [NET6_0, NET45] (5.0.6.0, 5.0.5.0, 6.0.0.0)
```

# Notice

* It will log the version of the Archipelago.MultiClient.Net library, so its either `NET35`, `NET40`, `NET45`, `NETSTANDARD2_0`, `NET6_0` regardless of what framework version is actually used by the client
* This tool itzelf uses the Archipelago.MultiClient.Net, and will cause an `NET6_0` entry to be added under whatever game its connecting under
