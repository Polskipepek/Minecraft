public class BlockSpawner : Spawner {

    public override void Spawn () {

    }

    public BlockSpawner GetInstance () {
        if (_getInstance == null) {
            _getInstance = this;
        }
        return (BlockSpawner) _getInstance;
    }
}
