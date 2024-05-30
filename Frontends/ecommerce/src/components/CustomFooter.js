import React from "react";

function CustomFooter() {
  return (
    <div
      className="footer"
      style={{
        backgroundColor: "black",
        display: "flex",
        justifyContent: "space-between",

        padding: "2rem 1.5rem",
        columnGap: "1rem",
      }}
    >
      <div>
        <p style={{ color: "white", fontSize: "2rem" }}>
          Sağlıklı Yaşamınız İçin En İyi Takviyeleri Keşfedin: NutriHub ®
        </p>
      </div>
      <div style={{ color: "white" }}>
        <span>
          <p>
            İstanbul, Türkiye<br></br>
            <br></br>
          </p>
        </span>
        <span>
          info@nutrihub.com<br></br>
          +90 212 574 8654<br></br>
          Aydınevler, Siteler Yolu No:28, 34854 Maltepe/İstanbul<br></br>
        </span>
        <span>
          <br></br>
          <a
            style={{
              color: "white",
              marginTop: "1rem",
              cursor: "pointer",
              textDecoration: "underline",
            }}
          >
            SEE ON MAP<i className="ri-arrow-right-up-line"></i>
          </a>
        </span>
      </div>
      <div style={{ color: "white" }}>
        <span>
          <p>
            Ankara, Türkiye<br></br>
            <br></br>
          </p>
        </span>
        <span>
          info@nutrihub.com<br></br>
          +90 212 574 8654<br></br>
          Aydınevler, Siteler Yolu No:28, 34854 Çankaya/Ankara<br></br>
        </span>
        <span>
          <br></br>
          <a
            style={{
              color: "white",
              marginTop: "1rem",
              cursor: "pointer",
              textDecoration: "underline",
            }}
          >
            SEE ON MAP<i className="ri-arrow-right-up-line"></i>
          </a>
        </span>
      </div>
      <div style={{ color: "white" }}>
        <a
          style={{
            color: "white",
            textDecoration: "underline",
            cursor: "pointer",
          }}
        >
          GELİŞMELERDEN HABERDAR OLUN <i className="ri-arrow-right-up-line"></i>
        </a>
        <br></br>
        <br></br>
        <br></br>
        <br></br>

        <p>BİZİ TAKİP EDİN!</p>
        <br></br>
        <div
          style={{
            display: "flex",
            justifyContent: "space-between",
            fontSize: "2rem",
          }}
        >
          <i
            className="ri-facebook-circle-line"
            style={{ cursor: "pointer" }}
          ></i>
          <i className="ri-instagram-line" style={{ cursor: "pointer" }}></i>
          <i className="ri-twitter-x-line" style={{ cursor: "pointer" }}></i>
          <a href="https://www.youtube.com/@clashbros15">
            <i
              className="ri-youtube-line"
              style={{ cursor: "pointer", color: "white" }}
            ></i>
          </a>
        </div>
      </div>
    </div>
  );
}

export default CustomFooter;
