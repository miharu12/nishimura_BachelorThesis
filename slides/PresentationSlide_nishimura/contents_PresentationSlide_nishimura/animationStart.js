const animationStartMap = {
start0: () => {
    repeatSeq(animationSeqID0, 60, 600, () => {
    });
},
start1: () => {
    repeatSeq(animationSeqID1, 30, 1000, () => {
    });
},
start2: () => {
    repeatSeq(animationSeqID2, 60, 600, () => {
    });
},
start3: () => {
    repeatSeq(animationSeqID3, 6, 500, () => {
    repeatSeq(animationSeqID4, 6, 100, () => {
    });
    });
},
start4: () => {
    repeatSeq(animationSeqID5, 60, 900, () => {
    });
},
test: () => {}
};
