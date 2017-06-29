using System;

namespace CodeChain.Models {
    /// Block of the chain
    public class Block {
        /// Number of block
        public ulong Number;
        /// Parent block hash
        public byte[] ParentHash;
        /// Current block hash
        public byte[] Hash;
        /// Block data
        public byte[] Data;
        /// Block timestamp UTC
        public DateTime Time;
        /// Block owner address - Node address which produce block
        public Address Owner;
    }
}