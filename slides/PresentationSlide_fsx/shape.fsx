//#############################################################################
// project title
let projectname = "shape"
let version = "1.0.0"
//#############################################################################

let outputdir = @"C:\home\work"

#I @"..\bin\Debug\net9.0"
#r "docWriter.dll"

open System
open docWriter

fixedPage outputdir "shape" 1920 1080 {Character=OFF; Subtitle=OFF; Voice=OFF} <| fun wr ->
    
    html.page //1ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Dang;
         Source = AudioFile @"C:\home\contents\008-scripts_台詞_D.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.animation outputdir "shape" {sX=700; sY=580; mX=1140; mY=250; backgroundColor="#bbeeff"} p (1080,250) <| fun (f,p) ->
                let line1 = f.animationLine Style[stroke.width 4.0; stroke.dash "4,4"; stroke.color "#ff69b4"]
                let elps1 = f.animationArc Style[stroke.width 6.0; stroke.color "#006400"; stroke.fill "none";]
                /// 中心座標
                let cx,cy = I 350, I 290
                let constCenter = { X = (fun _ -> cx); Y = fun _ -> cy }
                /// 円弧の半径
                let R = D 198.0
                // 中心から右に破線描画
                f.seq {FrameTime=6; FrameNumber=500} <| fun s ->
                    line1.P {
                        Start = constCenter
                        End = {
                            X = fun t -> cx + R*t/(s.FrameNumber-1)
                            Y = fun _ -> cy }}
                // 円弧描画
                f.seq {FrameTime=6; FrameNumber=100} <| fun s ->
                    elps1.P {
                        center = constCenter
                        angle1 = fun _ -> I 0
                        angle2 = fun t -> 360*t/(s.FrameNumber-1)
                        radius = fun _ -> R }

    html.page //2ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\work\PresentationSlide_nishimura\0-中間発表T01.wav"
         Subtitle = Serif "こんなふうに、音声も流せるんですよね。"}
        <| fun p ->
            html.animation outputdir "PresentationSlide_nishimura" {sX=700; sY=780; mX=610; mY=80; backgroundColor="#bbeeff"} p (540,100) <| fun (f,p) ->
                let n = 40
                let m = 10
                let pointR = I 5
                f.seq {FrameTime=60; FrameNumber=900} <| fun _ ->
                    for j in 0 .. (m-1) do
                        for i in 0 .. (n-1) do
                            let elps0 = f.animationEllipse Style[stroke.width 3.0; stroke.color "#0000ff"; stroke.fill "#0000ff";]
                            elps0.P {
                                center = { X = (fun _ -> Dbl_e 10+20*i );
                                           Y = fun t -> 0+100*j+100*asm.sin(Dbl_e i*0.1-2.0*Math.PI*t/100)}
                                radiusX = fun _ -> pointR
                                radiusY = fun _ -> pointR}


    html.page //2ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\work\PresentationSlide_nishimura\0-中間発表T01.wav"
         Subtitle = Serif "こんなふうに、音声も流せるんですよね。"}
        <| fun p ->
            html.contents Style[] (p+position(50,50)) "アニメーション制御の実装"
            html.subtitle1 Style[] (p+position(80,150)) "アニメーション処理（例：直線）"
            html.subtitle2 Style[] (p+position(100,250)) "Aqualis（ユーザが作成）"
            html.textA Style[] (p+position(450,650)) "line0：線幅 3.0 の赤色の実線"
            html.textA Style[] (p+position(450,700)) "line1：線幅 3.0 の緑色の破線"
            html.textA Style[] (p+position(450,750)) "line2：線幅 3.0 の黒色の破線"
            html.textA Style[] (p+position(450,800)) "line3：線幅 5.0 の赤色の実線"
            html.blockTextcode Style[] 
                <|(p+position(120,300))
                <|(860.0, 780.0)
                <| [
                    "let line0 = f.animationLine Style[stroke.width 3.0; stroke.color \"#ff0000\"]"
                    "let line1 = f.animationLine Style[stroke.width 3.0; stroke.dash \"1,3\";"
                    "                                                    stroke.color \"#008000\"]"
                    "let line2 = f.animationLine Style[stroke.width 3.0; stroke.dash \"4,4\";"
                    "                                                    stroke.color \"#000000\"]"
                    "let line3 = f.animationLine Style[stroke.width 5.0; stroke.color \"#000000\"]"
                ]
                |> ignore
            html.animation outputdir "PresentationSlide_nishimura" {sX=700; sY=440; mX=1080; mY=300; backgroundColor="#bbeeff"} p (1010,300) <| fun (f,p) ->
                let line0 = f.animationLine Style[stroke.width 3.0; stroke.color "#ff0000"]
                let line1 = f.animationLine Style[stroke.width 3.0; stroke.dash "1,3"; stroke.color "#008000"]
                let line2 = f.animationLine Style[stroke.width 3.0; stroke.dash "4,4"; stroke.color "#000000"]
                let line3 = f.animationLine Style[stroke.width 5.0; stroke.color "#000000"]
                let text0 = f.animationText Style[stroke.width 3.0; font.color "#ff0000"]
                let text1 = f.animationText Style[stroke.width 3.0; font.color "#008000"]
                let text2 = f.animationText Style[stroke.width 3.0; font.color "#000000"]
                let text3 = f.animationText Style[stroke.width 3.0; font.color "#000000"]
                f.seq {FrameTime=30; FrameNumber=1000} <| fun _ ->
                        line0.P {Start = {X = fun _ -> Dbl_e 60
                                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}
                                 End = {X = fun _ -> Dbl_e 160
                                        Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}
                        line1.P {Start = {X = fun _ -> Dbl_e 220
                                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}
                                 End = {X = fun _ -> Dbl_e 320
                                        Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}
                        line2.P {Start = {X = fun _ -> Dbl_e 380
                                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}
                                 End = {X = fun _ -> Dbl_e 480
                                        Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}
                        line3.P {Start = {X = fun _ -> Dbl_e 540
                                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}
                                 End = {X = fun _ -> Dbl_e 640
                                        Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}
                        text0.P {str = "line0"
                                 center = {X = fun _ -> Dbl_e 110
                                           Y = fun _ -> Dbl_e 50}}
                        text1.P {str = "line1"
                                 center = {X = fun _ -> Dbl_e 270
                                           Y = fun _ -> Dbl_e 50}}
                        text2.P {str = "line2"
                                 center = {X = fun _ -> Dbl_e 430
                                           Y = fun _ -> Dbl_e 50}}
                        text3.P {str = "line3"
                                 center = {X = fun _ -> Dbl_e 590
                                           Y = fun _ -> Dbl_e 50}}
