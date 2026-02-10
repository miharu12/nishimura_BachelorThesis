const animationResetMap = {
reset0: () => {
    animationSeqResetID0();
},
reset1: () => {
    animationSeqResetID1();
},
reset2: () => {
    animationSeqResetID2();
},
reset3: () => {
    animationSeqResetID3();
    animationSeqResetID4();
},
reset4: () => {
    animationSeqResetID5();
},
test: () => {}
};

function resetAll(){
    for (const key in animationResetMap) {
        if (typeof animationResetMap[key] === "function") {
            animationResetMap[key]();
        }
    }
}
