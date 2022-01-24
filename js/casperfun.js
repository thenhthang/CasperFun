//Mainnet
//const apiUrl = 'http://34.66.154.252:7777/rpc';
//Testnet
const apiUrl = 'http://138.201.54.44:7777/rpc';
const casperService = new CasperServiceByJsonRPC(apiUrl);
const casperClient = new CasperClient(apiUrl);

async function connect() {
    await window.casperlabsHelper.requestConnection();
}
function disConnect() {
    window.casperlabsHelper.disconnectFromSite();
}
async function getAddress() {
    try {
        const isConnected = await window.casperlabsHelper.isConnected();
        if (isConnected) {
            const publicKey = await window.casperlabsHelper.getActivePublicKey();
            console.log(publicKey);
            return publicKey;
        } else {
            return "";
        }
    } catch(error) {
        return "";
    }
}
async function getBalance() {
    const isConnected = await window.casperlabsHelper.isConnected()
    if (isConnected) {
        console.log("Connected");
        const publicKey = await window.casperlabsHelper.getActivePublicKey();
        console.log(publicKey);
        const latestBlock = await casperService.getLatestBlockInfo();
        const root = await casperService.getStateRootHash(latestBlock.block.hash);

        const balanceUref = await casperService.getAccountBalanceUrefByPublicKey(
            root,
            CLPublicKey.fromHex(publicKey)
        )

        //account balance from the last block
        const balance = await casperService.getAccountBalance(
            latestBlock.block.header.state_root_hash,
            balanceUref
        );
        return balance.toString();
    } else {
        console.log("Not Connected");
        return "not connect";
    }
}
function sayHello() {
    alert("Hello");

}