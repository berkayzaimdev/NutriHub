import React, { useEffect, useState } from "react";
import "../pages/Home.css";
import image1 from "../images/image1.png";
import image2 from "../images/image2.png";
import image3 from "../images/image3.png";

import HomeProduct from "../components/HomeProduct";
import HomeBlogCard from "../components/HomeBlogCard";

function Home() {
  const images = [image1, image2, image3];
  const imagesLength = images.length;
  const [imageIndex, setImageIndex] = useState(0);

  useEffect(() => {
    console.log(imageIndex);
  }, []);
  return (
    <div className="home">
      <section className="home-presentation">
        <div className="home-description">
          <span className="home-subtitle">Nutritional Supplements</span>
          <h2 className="home-title">
            Sağlıklı Yaşamınız İçin En İyi Takviyeleri Keşfedin: NutriHub!
          </h2>
          <a className="home-sell-link" href="/urunler">
            Şimdi Al <i class="ri-arrow-right-line"></i>
          </a>
        </div>
        <div className="home-swiper">
          <i
            className="ri-arrow-left-wide-line"
            onClick={() => {
              if (imageIndex === 0) {
                setImageIndex(images.length - 1);
              } else {
                setImageIndex(imageIndex - 1);
              }
            }}
          ></i>
          <img
            src={images[imageIndex]}
            className="home-swiper-image"
            alt="NutriHub"
            title="NutriHub"
          ></img>
          <i
            class="ri-arrow-right-wide-line"
            onClick={() => {
              if (imageIndex === images.length - 1) {
                setImageIndex(0);
              } else {
                setImageIndex(imageIndex + 1);
              }
            }}
          ></i>
        </div>
        <div className="home-company-presentation">
          <span>
            <i className="ri-bank-card-line"></i> %100 Güvenli Alışveriş
          </span>
          <span>
            <i className="ri-customer-service-2-line"></i> Kapıda Ödeme İmkanı
          </span>
          <span>
            <i class="ri-phone-line"></i> 444 58 58
          </span>
        </div>
      </section>
      <section className="home-bestsellers">
        <h2 className="home-best-sellers-title">Çok Satanlar</h2>
        <div className="home-bestsellers-products">
          <HomeProduct></HomeProduct>
          <HomeProduct></HomeProduct>
          <HomeProduct></HomeProduct>
          <HomeProduct></HomeProduct>
          <HomeProduct></HomeProduct>
          <HomeProduct></HomeProduct>
        </div>
      </section>
      <section className="home-total-customer">
        <h2>NUTRIHUB 1 YAŞINDA</h2>
        <p className="home-total-customer-description">
          2003 yılından beri Türkiye’nin ilk spor gıdası markası olan Hardline
          Nutrition sporcu gıdaları ve gıda takviye ürünlerini en kaliteli
          şekilde kendi tesislerinde üretmektedir.
        </p>
        <div style={{ border: "1px solid white", margin: "2rem 20rem" }}></div>
        <span>
          <strong>
            <i class="ri-user-line"></i>{" "}
          </strong>
          20,000 Mutlu Müşteri
        </span>
      </section>
      <h2
        style={{ display: "block", textAlign: "center", marginTop: "1.5rem" }}
      >
        Bloglar
      </h2>
      <a
        style={{
          display: "block",
          textAlign: "end",
          marginRight: "8rem",
          cursor: "pointer",
          textDecoration: "underline",
        }}
      >
        Tümünü Oku
      </a>
      <section className="home-blog">
        <HomeBlogCard></HomeBlogCard>
        <HomeBlogCard></HomeBlogCard>
        <HomeBlogCard></HomeBlogCard>
      </section>
    </div>
  );
}

export default Home;
