import React from "react";

function Register() {
  const togglePasswordVisibility = (inputId) => {
    const passwordInput = document.getElementById(inputId);
    const showIcon = document.getElementById("showPassword");
    const hideIcon = document.getElementById("hidePassword");

    if (passwordInput.type === "password") {
      passwordInput.type = "text";
      showIcon.style.display = "none";
      hideIcon.style.display = "block";
    } else {
      passwordInput.type = "password";
      showIcon.style.display = "block";
      hideIcon.style.display = "none";
    }
  };

  return (
    <div
      style={{
        fontFamily: "'Segoe UI', Tahoma, Geneva, Verdana, sans-serif",
        backgroundColor: "#f8f9fa",
        marginTop: "8rem",
        marginBottom: "1rem",
      }}
    >
      <div
        style={{
          maxWidth: "500px",
          margin: "0 auto",
          padding: "20px",
          backgroundColor: "#fff",
          borderRadius: "10px",
          boxShadow: "0 0 20px rgba(0, 0, 0, 0.1)",
        }}
      >
        <h1
          style={{ textAlign: "center", color: "#333", marginBottom: "30px" }}
        >
          Kayıt Ol
        </h1>
        <form action="#" method="post">
          <div style={{ marginBottom: "20px", position: "relative" }}>
            <input type="text" placeholder="Ad" name="FirstName" required />
            <i className="bx bxs-user"></i>
          </div>
          <div style={{ marginBottom: "20px", position: "relative" }}>
            <input type="text" placeholder="Soyad" name="LastName" required />
            <i className="bx bxs-user"></i>
          </div>
          <div style={{ marginBottom: "20px", position: "relative" }}>
            <input type="text" placeholder="E-posta" name="Email" required />
            <i className="bx bxs-envelope"></i>
          </div>
          <div style={{ marginBottom: "20px", position: "relative" }}>
            <input
              type="password"
              placeholder="Şifre"
              name="Password"
              id="password"
              required
            />
            <i
              className="bx bxs-show"
              id="showPassword"
              onClick={() => togglePasswordVisibility("password")}
            ></i>
            <i
              className="bx bxs-hide"
              id="hidePassword"
              style={{ display: "none" }}
              onClick={() => togglePasswordVisibility("password")}
            ></i>
            <p style={{ color: "#dc3545", fontSize: "14px", marginTop: "5px" }}>
              Şifreniz en az 8 karakter olmalı, harf ve rakam içermelidir.
            </p>
          </div>

          <div className="recaptcha-container">
            <label className="lr-label">
              <br />
              Doğrulama Resmi
            </label>
            <div className="recaptcha-container">
              <script
                async=""
                src="https://www.google.com/recaptcha/api.js?hl=tr-TR"
                defer=""
                type="text/javascript"
              ></script>
              <div
                className="g-recaptcha"
                data-sitekey="6LfmuPUSAAAAAOMXRogrcZllsDCIfDvj-slDsGZE"
                data-theme="light"
              >
                <div style={{ width: "304px", height: "78px" }}>
                  <div>
                    <iframe
                      title="reCAPTCHA"
                      width="304"
                      height="78"
                      role="presentation"
                      name="a-gwcvi07idv3z"
                      frameBorder="0"
                      scrolling="no"
                      sandbox="allow-forms allow-popups allow-same-origin allow-scripts allow-top-navigation allow-modals allow-popups-to-escape-sandbox allow-storage-access-by-user-activation"
                      src="https://www.google.com/recaptcha/api2/anchor?ar=1&amp;k=6LfmuPUSAAAAAOMXRogrcZllsDCIfDvj-slDsGZE&amp;co=aHR0cHM6Ly93d3cuc3VwcGxlbWVudGxlci5jb206NDQz&amp;hl=tr&amp;v=1kRDYC3bfA-o6-tsWzIBvp7k&amp;theme=light&amp;size=normal&amp;cb=ibcfpdog6rgf"
                    ></iframe>
                  </div>
                  <textarea
                    id="g-recaptcha-response"
                    name="g-recaptcha-response"
                    className="g-recaptcha-response"
                    style={{
                      width: "250px",
                      height: "40px",
                      border: "1px solid rgb(193, 193, 193)",
                      margin: "10px 25px",
                      padding: "0px",
                      resize: "none",
                      display: "none",
                    }}
                  ></textarea>
                </div>
                <iframe style={{ display: "none" }}></iframe>
              </div>
            </div>
          </div>

          <div style={{ marginBottom: "20px" }}>
            <button
              type="submit"
              style={{
                width: "100%",
                padding: "12px",
                border: "none",
                borderRadius: "5px",
                backgroundColor: "#28a745",
                color: "#fff",
                fontSize: "16px",
                cursor: "pointer",
                transition: "background-color 0.3s ease",
              }}
            >
              Üyeliğimi Tamamla
            </button>
          </div>
          <div style={{ marginBottom: "20px" }}>
            <label>
              <input type="checkbox" name="SendEMail" value="true" required />
              Kişisel verilerimin işlenmesine ve tarafıma ticari elektronik
              ileti gönderilmesine burada belirtilen Rıza Metni ile onay
              veriyorum.
            </label>
          </div>
        </form>
        <a
          href="giris-yap"
          className="login-link"
          style={{ cursor: "pointer", textDecoration: "underline" }}
        >
          Zaten bir hesabınız var mı? Giriş Yapın
        </a>
      </div>
    </div>
  );
}

export default Register;
