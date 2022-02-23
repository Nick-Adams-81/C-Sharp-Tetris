using System;
namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
           new IBLock(),
           new JBlock(),
           new LBlock(),
           new OBlock(),
           new SBlock(),
           new TBlock(),
           new ZBlock()
        };

        private readonly Random random = new Random();

        public Block NextBlock { get; set; }

        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }


        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }

        public block GetAndUpdate()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = RandomBlock();
            }

            while (block.Id == NextBlock.Id);

            return block;
        }
    }
}
