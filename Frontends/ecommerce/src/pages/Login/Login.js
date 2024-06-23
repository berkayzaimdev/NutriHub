import React from "react";

function Login() {
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
          Giriş Yap
        </h1>
        <form action="#" method="post">
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
              Giriş Yap
            </button>
          </div>
        </form>
        <a
          href="/Users/Gürkan/Desktop/eticaret/register.html"
          className="login-link"
        >
          Hesabınız yok mu? Hemen Kaydolun
        </a>
      </div>
    </div>
  );
}

export default Login;
