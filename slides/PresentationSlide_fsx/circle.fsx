//#############################################################################
// project title
let projectname = "circle"
let version = "1.0.0"
//#############################################################################

let outputdir = @"C:\home\work"

#I @"..\bin\Debug\net9.0"
#r "docWriter.dll"

open System
open docWriter

fixedPage outputdir "circle" 1920 1080 {Character=OFF; Subtitle=OFF; Voice=OFF} <| fun wr ->
    
    html.page //1ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Dang;
         Source = AudioFile @"C:\home\contents\008-scripts_台詞_D.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.animation outputdir "circle" {sX=800; sY=580; mX=1040; mY=450; backgroundColor="#bbeeff"} p (960,450) <| fun (f,p) ->
                /// 中心座標
                let cx,cy = I 400, I 290
                let constCenter = { X = (fun _ -> cx); Y = fun _ -> cy }
                /// 点の半径
                let pointR = I 4
                f.seq {FrameTime=6; FrameNumber=50} <| fun _ ->
                    let elps0 = f.animationEllipse Style[stroke.width 3.0; stroke.color "#0000ff"; stroke.fill "#0000ff";]
                    elps0.P {
                        center = constCenter
                        radiusX = fun t -> pointR*t
                        radiusY = fun t -> pointR*t }

    html.page //1ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Dang;
         Source = AudioFile @"C:\home\contents\008-scripts_台詞_D.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.animation outputdir "PresentationSlide_nishimura" {sX=700; sY=440; mX=160; mY=590; backgroundColor="#bbeeff"} p (100,590) <| fun (f,p) ->
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
