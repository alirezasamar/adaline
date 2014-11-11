Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        t10.Text = 1
        t11.Text = 1
        t12.Text = -1
        t13.Text = -1

        t20.Text = 1
        t21.Text = -1
        t22.Text = 1
        t23.Text = -1

        tgt0.Text = -1
        tgt1.Text = 1
        tgt2.Text = -1
        tgt3.Text = -1

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Step0: Initializing weights and bias
        Dim alpha As Double

        alpha = 0.2

        'Step3: Set activation for input units
        dw10.Text = t10.Text * tgt0.Text
        dw11.Text = t11.Text * tgt1.Text
        dw12.Text = t12.Text * tgt2.Text
        dw13.Text = t13.Text * tgt3.Text

        dw20.Text = t20.Text * tgt0.Text
        dw21.Text = t21.Text * tgt1.Text
        dw22.Text = t22.Text * tgt2.Text
        dw23.Text = t23.Text * tgt3.Text

        tgtbaru10.Text = tgt0.Text
        tgtbaru11.Text = tgt1.Text
        tgtbaru12.Text = tgt2.Text
        tgtbaru13.Text = tgt3.Text

        w11.Text = Val(dw10.Text) + Val(w10.Text)
        w21.Text = Val(dw20.Text) + Val(w20.Text)
        tgtbaru21.Text = Val(tgt0.Text) + Val(tgtbaru20.Text)

        w12.Text = Val(dw11.Text) + Val(w11.Text)
        w22.Text = Val(dw21.Text) + Val(w21.Text)
        tgtbaru22.Text = Val(tgt1.Text) + Val(tgtbaru21.Text)

        w13.Text = Val(dw12.Text) + Val(w12.Text)
        w23.Text = Val(dw22.Text) + Val(w22.Text)
        tgtbaru23.Text = Val(tgt2.Text) + Val(tgtbaru22.Text)

        w14.Text = Val(dw13.Text) + Val(w13.Text)
        w24.Text = Val(dw23.Text) + Val(w23.Text)
        tgtbaru24.Text = Val(tgt3.Text) + Val(tgtbaru23.Text)

        'Step4: Compute net input to output unit
        net10.Text = Val(tgtbaru20.Text) + Val(Val(t10.Text * w10.Text) + Val(t20.Text * w20.Text))
        r10.Text = Val(tgt0.Text) - Val(net10.Text)

        'Step5: Update weights and bias
        'delta weights
        dw10.Text = alpha * (r10.Text) * Val(t10.Text)
        dw20.Text = alpha * (r10.Text) * Val(t20.Text)
        tgtbaru10.Text = alpha * (r10.Text) * Val(t30.Text)

        'weights
        w11.Text = Val(w10.Text) + alpha * (r10.Text) * Val(t10.Text)
        w21.Text = Val(w20.Text) + alpha * (r10.Text) * Val(t20.Text)
        tgtbaru21.Text = Val(tgtbaru20.Text) + alpha * (r10.Text) * Val(t30.Text)

        net11.Text = Val(tgtbaru21.Text) + Val(Val(t11.Text * w11.Text) + Val(t21.Text * w21.Text))
        r11.Text = Val(tgt1.Text) - Val(net11.Text)

        dw11.Text = alpha * (r11.Text) * Val(t11.Text)
        dw21.Text = alpha * (r11.Text) * Val(t21.Text)
        tgtbaru11.Text = alpha * (r11.Text) * Val(t31.Text)

        w12.Text = Val(w11.Text) + alpha * (r11.Text) * Val(t11.Text)
        w22.Text = Val(w21.Text) + alpha * (r11.Text) * Val(t21.Text)
        tgtbaru22.Text = Val(tgtbaru21.Text) + alpha * (r11.Text) * Val(t31.Text)

        net12.Text = Val(tgtbaru22.Text) + Val(Val(t12.Text * w12.Text) + Val(t22.Text * w22.Text))
        r12.Text = Val(tgt2.Text) - Val(net12.Text)

        dw12.Text = alpha * (r12.Text) * Val(t12.Text)
        dw22.Text = alpha * (r12.Text) * Val(t22.Text)
        tgtbaru12.Text = alpha * (r12.Text) * Val(t32.Text)

        w13.Text = Val(w12.Text) + alpha * (r12.Text) * Val(t12.Text)
        w23.Text = Val(w22.Text) + alpha * (r12.Text) * Val(t22.Text)
        tgtbaru23.Text = Val(tgtbaru22.Text) + alpha * (r12.Text) * Val(t32.Text)

        net13.Text = Val(tgtbaru23.Text) + Val(Val(t13.Text * w13.Text) + Val(t23.Text * w23.Text))
        r13.Text = Val(tgt3.Text) - Val(net13.Text)

        dw13.Text = alpha * (r13.Text) * Val(t13.Text)
        dw23.Text = alpha * (r13.Text) * Val(t23.Text)
        tgtbaru13.Text = alpha * (r13.Text) * Val(t33.Text)

        w14.Text = Val(w13.Text) + alpha * (r13.Text) * Val(t13.Text)
        w24.Text = Val(w23.Text) + alpha * (r13.Text) * Val(t23.Text)
        tgtbaru24.Text = Val(tgtbaru23.Text) + alpha * (r13.Text) * Val(t33.Text)

        'The squared error
        e0.Text = Val(r10.Text) ^ 2
        e1.Text = Val(r11.Text) ^ 2
        e2.Text = Val(r12.Text) ^ 2
        e3.Text = Val(r13.Text) ^ 2


    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        t10.Text = ""
        t11.Text = ""
        t12.Text = ""
        t13.Text = ""

        t20.Text = ""
        t21.Text = ""
        t22.Text = ""
        t23.Text = ""

        tgt0.Text = ""
        tgt1.Text = ""
        tgt2.Text = ""
        tgt3.Text = ""

        dw10.Text = ""
        dw11.Text = ""
        dw12.Text = ""
        dw13.Text = ""

        dw20.Text = ""
        dw21.Text = ""
        dw22.Text = ""
        dw23.Text = ""

        net10.Text = ""
        net11.Text = ""
        net12.Text = ""
        net13.Text = ""

        r10.Text = ""
        r11.Text = ""
        r12.Text = ""
        r13.Text = ""

        e0.Text = ""
        e1.Text = ""
        e2.Text = ""
        e3.Text = ""

        tgtbaru10.Text = ""
        tgtbaru11.Text = ""
        tgtbaru12.Text = ""
        tgtbaru13.Text = ""

        w10.Text = "0.2"
        w20.Text = "0.2"
        tgtbaru20.Text = "0.2"

        w11.Text = ""
        w12.Text = ""
        w13.Text = ""
        w14.Text = ""

        w21.Text = ""
        w22.Text = ""
        w23.Text = ""
        w24.Text = ""

        tgtbaru21.Text = ""
        tgtbaru22.Text = ""
        tgtbaru23.Text = ""
        tgtbaru24.Text = ""

    End Sub
End Class
