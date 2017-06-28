namespace CodeChain.Models {
    /// Block of the chain
    public class Block {
        /// Number of block
        public ulong Number;

        /// Current block hash
        public byte[] Hash;
        /// Block data
        public byte[] Data;
    }
}