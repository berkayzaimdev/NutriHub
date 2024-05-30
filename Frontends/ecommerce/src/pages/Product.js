import React, { useState } from "react";
import "./Product.css";
import image1 from "../images/image1.png";
import HomeProduct from "../components/HomeProduct";
import ProductCard from "../components/ProductCard";

function Product() {
  const [heartName, setHeartName] = useState("ri-heart-line");
  const [productPiece, setProductPiece] = useState(1);
  return (
    <div className="product">
      <section className="product-category">
        <a className="product-category-item">NUTRIHUB</a>
        <i className="ri-arrow-drop-right-line"></i>
        <a className="product-category-item">Protein Tozu</a>
        <i className="ri-arrow-drop-right-line"></i>
        <a className="product-category-item">Progainer Çikolata 5000 Gr</a>
      </section>
      <section className="product-information">
        <div className="product-information-image">
          <img src={image1} className="product-information-image-item"></img>
        </div>
        <div className="product-information-features">
          <div className="product-information-name">
            <p>Progainer Çikolata 5000 Gr</p>
            <div className="product-information-user-interaction">
              <div className="product-stars">
                <span>4.3 {"  "}</span>
                <i className="ri-star-s-fill"></i>
                <i className="ri-star-s-fill"></i>
                <i className="ri-star-s-fill"></i>
                <i className="ri-star-s-fill"></i>
                <i className="ri-star-half-s-line"></i>
              </div>

              <div className="product-information-comment-number">
                <span>547 Değerlendirme</span>
              </div>
              <div
                className="product-information-favourites"
                onMouseEnter={() => {
                  setHeartName("ri-heart-fill");
                }}
                onMouseLeave={() => {
                  setHeartName("ri-heart-line");
                }}
              >
                <i className={heartName}></i>
                {"  "}624 Favori
              </div>
            </div>
            <span className="product-information-price">599,00 TL</span>
          </div>
          <span>
            <p style={{ marginTop: "1rem" }}>Ürün Adedi:</p>
          </span>
          <div className="product-piece">
            <div>
              <p>Adet Seçimi</p>
              <p>Sipariş Limiti: 11 Adet</p>
            </div>
            <div className="product-piece-adding">
              <i
                class="ri-add-circle-fill"
                onClick={() => {
                  if (productPiece === 11) {
                  } else {
                    setProductPiece(productPiece + 1);
                  }
                }}
              ></i>
              <p>{productPiece}</p>
              <i
                class="ri-indeterminate-circle-fill"
                onClick={() => {
                  if (productPiece === 1) {
                  } else {
                    setProductPiece(productPiece - 1);
                  }
                }}
              ></i>
            </div>
          </div>
          <div className="product-add-cart">
            <div className="product-add-cart-button">
              <p>Sepete Ekle</p>
            </div>
            <i class="ri-heart-line"></i>
          </div>
          <div className="product-information-share">
            <p>Paylaş:</p>
            <div className="product-information-share-icon">
              <i class="ri-facebook-box-fill" style={{ color: "blue" }}></i>
              <i class="ri-instagram-fill" style={{ color: "purple" }}></i>
              <i class="ri-twitter-x-line"></i>
              <i class="ri-whatsapp-line" style={{ color: "green" }}></i>
              <i class="ri-share-fill" style={{ color: "brown" }}></i>
            </div>
          </div>
          <div className="product-information-description">
            <p>
              Düşük ısıda mikro filtre edilmiş, yüksek standartlı whey protein
              konsantresi, whey protein izolatı ve peptid formdaki whey protein
              hidrolizatı ile formüle edilmiş özel üründür. İlave şeker,
              karbonhidrat veya yağ içermez. Kıvamı ve hafif içimi ile damak
              zevkine hitap eder. Aspartam içermez
            </p>
          </div>
        </div>
      </section>
      <section className="product_similar-products">
        <p>Benzer Ürünler</p>
        <div className="product_similar-products-product">
          <ProductCard></ProductCard>
          <ProductCard></ProductCard>
          <ProductCard></ProductCard>
          <ProductCard></ProductCard>
        </div>
      </section>
      <section className="product_comments">
        <p className="product_comments-title">Ürün Yorumları</p>
        <div className="product_user-comment">
          <div className="product_user-comment-text">
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-half-s-line"></i>
            <div style={{ marginLeft: "2rem" }}>
              SÜRELİ CİLT BAKIMI YAPTIĞIM HALDE O DİKKATLİ BAKMADAN GÖRÜNMEYEN
              SİYAH NOKTALARIMI MIKNATIS GİBİ ÇEKTİ İNDİRİMDE STOKLAMAYI
              DÜŞÜNÜYORUM TEŞEKKÜRLER
            </div>
          </div>
          <div className="product_user-comment-information">
            <div className="product_user-comment-username">
              <p>Namık Kemal</p>
              <p> | </p>
              <p>15 Aralık 2021</p>
            </div>
            <div className="product_user-comment-information-like">
              <i class="ri-thumb-up-line"></i>
              Yorumu Beğendi (3)
            </div>
          </div>
        </div>
        <div className="product_user-comment">
          <div className="product_user-comment-text">
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-half-s-line"></i>
            <div style={{ marginLeft: "2rem" }}>
              SÜRELİ CİLT BAKIMI YAPTIĞIM HALDE O DİKKATLİ BAKMADAN GÖRÜNMEYEN
              SİYAH NOKTALARIMI MIKNATIS GİBİ ÇEKTİ İNDİRİMDE STOKLAMAYI
              DÜŞÜNÜYORUM TEŞEKKÜRLER
            </div>
          </div>
          <div className="product_user-comment-information">
            <div className="product_user-comment-username">
              <p>Namık Kemal</p>
              <p> | </p>
              <p>15 Aralık 2021</p>
            </div>
            <div className="product_user-comment-information-like">
              <i class="ri-thumb-up-line"></i>
              Yorumu Beğendi (3)
            </div>
          </div>
        </div>
        <div className="product_user-comment">
          <div className="product_user-comment-text">
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-s-fill"></i>
            <i className="ri-star-half-s-line"></i>
            <div style={{ marginLeft: "2rem" }}>
              SÜRELİ CİLT BAKIMI YAPTIĞIM HALDE O DİKKATLİ BAKMADAN GÖRÜNMEYEN
              SİYAH NOKTALARIMI MIKNATIS GİBİ ÇEKTİ İNDİRİMDE STOKLAMAYI
              DÜŞÜNÜYORUM TEŞEKKÜRLER
            </div>
          </div>
          <div className="product_user-comment-information">
            <div className="product_user-comment-username">
              <p>Namık Kemal</p>
              <p> | </p>
              <p>15 Aralık 2021</p>
            </div>
            <div className="product_user-comment-information-like">
              <i class="ri-thumb-up-line"></i>
              Yorumu Beğendi (3)
            </div>
          </div>
        </div>
      </section>
    </div>
  );
}

export default Product;
