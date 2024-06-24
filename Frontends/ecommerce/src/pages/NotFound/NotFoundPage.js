import React from "react";

function NotFoundPage() {
  const containerStyle = {
    fontFamily: "Arial, sans-serif",
    textAlign: "center",
    padding: "50px",
    margin: "13rem 0",
  };

  const headingStyle = {
    fontSize: "50px",
    margin: "0",
  };

  const paragraphStyle = {
    fontSize: "20px",
  };

  const linkStyle = {
    color: "#007BFF",
    textDecoration: "none",
  };

  return (
    <div style={containerStyle}>
      <h1 style={headingStyle}>404</h1>
      <p style={paragraphStyle}>Üzgünüz, aradığınız sayfa bulunamadı.</p>
      <p style={paragraphStyle}>
        <a style={linkStyle} href="/">
          Ana sayfaya dön
        </a>
      </p>
    </div>
  );
}

export default NotFoundPage;
