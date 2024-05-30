import React, { useState } from "react";
import "./MyCart.css";
import MyCart_ProductCard from "../components/MyCart_ProductCard";
import ProductCard from "../components/ProductCard";
import { Form, InputGroup } from "react-bootstrap";

function MyCart() {
  const [myCartOption, setMyCartOption] = useState({
    first: true,
    second: false,
    third: false,
  });

  const clickMyCartOption = (option) => {
    setMyCartOption({
      first: option === "first",
      second: option === "second",
      third: option === "third",
    });
  };
  return (
    <div className="myCart">
      <div className="myCart-pages">
        <i
          className="ri-number-1"
          onClick={() => {
            clickMyCartOption("first");
          }}
          style={{
            backgroundColor: myCartOption.first === true ? "black" : "white",
            color: myCartOption.first === true ? "white" : "black",
          }}
        ></i>
        <div className="myCart-pages-line"></div>
        <i
          className="ri-number-2"
          onClick={() => {
            clickMyCartOption("second");
          }}
          style={{
            backgroundColor: myCartOption.second === true ? "black" : "white",
            color: myCartOption.second === true ? "white" : "black",
          }}
        ></i>
        <div className="myCart-pages-line"></div>
        <i
          className="ri-number-3"
          onClick={() => {
            clickMyCartOption("third");
          }}
          style={{
            backgroundColor: myCartOption.third === true ? "black" : "white",
            color: myCartOption.third === true ? "white" : "black",
          }}
        ></i>
      </div>
      <div
        style={{
          display: "flex",
          justifyContent: "space-between",
          marginBottom: "1rem",
        }}
      >
        <h2>Sepetim</h2>
        <h3>2 ürün</h3>
      </div>
      <div className="myCart-presentation">
        {myCartOption.first && (
          <div className="myCart-products">
            <MyCart_ProductCard></MyCart_ProductCard>
            <MyCart_ProductCard></MyCart_ProductCard>
            <MyCart_ProductCard></MyCart_ProductCard>
          </div>
        )}
        {myCartOption.second && (
          <div>
            <div
              style={{
                padding: "1rem",
                border: "1px solid gray",
                borderRadius: "12px",
                fontSize: "13px",
                marginBottom: "2rem",
                boxShadow: "0 0 10px gray",
              }}
            >
              <i class="ri-error-warning-line"></i>
              Kurumsal faturalı alışveriş yapmak için "Faturamı Aynı Adrese
              Gönder" tikini kaldırın ve Fatura adresi olarak kayıtlı Kurumsal
              Fatura adresinizi seçin.
            </div>
            <div style={{ display: "flex", columnGap: "1rem" }}>
              <div>
                <div
                  style={{ display: "flex", justifyContent: "space-between" }}
                >
                  <p>Teslimat Adresi</p>
                  <a style={{ cursor: "pointer", textDecoration: "underline" }}>
                    Düzenle
                  </a>
                </div>
                <div
                  style={{
                    marginTop: ".5rem",
                    padding: "1rem",
                    border: "1px solid gray",
                    borderRadius: "12px",
                    boxShadow: "0 0 5px gray",
                  }}
                >
                  <div
                    style={{
                      display: "flex",
                      justifyContent: "space-between",
                      fontSize: "12px",
                    }}
                  >
                    <i class="ri-user-line">{"  "} İSMAİL MERT AKPINAR</i>
                    <i class="ri-phone-line">(553) 553 5858</i>
                  </div>
                  <span>
                    Aydınevler, Siteler Yolu No:28, 34854 Maltepe/İstanbul
                  </span>
                </div>
              </div>
              <div>
                <div
                  style={{ display: "flex", justifyContent: "space-between" }}
                >
                  <p>Fatura Adresi</p>
                  <a style={{ cursor: "pointer", textDecoration: "underline" }}>
                    Düzenle
                  </a>
                </div>
                <div
                  style={{
                    marginTop: ".5rem",
                    padding: "1rem",
                    border: "1px solid gray",
                    borderRadius: "12px",
                    boxShadow: "0 0 5px gray",
                  }}
                >
                  <div
                    style={{
                      display: "flex",
                      justifyContent: "space-between",
                      fontSize: "12px",
                    }}
                  >
                    <i class="ri-user-line">{"  "} İSMAİL MERT AKPINAR</i>
                    <i class="ri-phone-line">(553) 553 5858</i>
                  </div>
                  <span>
                    Aydınevler, Siteler Yolu No:28, 34854 Maltepe/İstanbul
                  </span>
                </div>
              </div>
            </div>
          </div>
        )}
        {myCartOption.third && (
          <div style={{ width: "100%" }}>
            <div style={{ border: "1px solid gray", width: "100%" }}>
              <div style={{ padding: "1rem", borderBottom: "1px solid gray" }}>
                <p style={{ fontSize: "25px" }}>Kart ile Öde</p>
                <p>
                  Kart ile ödemeyi seçtiniz. Banka veya Kredi Kartı kullanarak
                  ödemenizi güvenle yapabilirsiniz.
                </p>
              </div>
              <div
                style={{
                  padding: "1rem",
                  display: "flex",
                  columnGap: "2rem",
                  justifyContent: "space-between",
                }}
              >
                <div>
                  <Form.Control
                    type="text"
                    placeholder="Kart Numarası"
                    style={{
                      padding: ".6rem",
                      width: "100%",
                      marginBottom: "1rem",
                    }}
                  />
                  <div
                    style={{ display: "flex", justifyContent: "space-between" }}
                  >
                    <Form.Select
                      aria-label="Default select example"
                      style={{ padding: ".6rem", width: "50%" }}
                    >
                      <option value="1">Ocak</option>
                      <option value="2">Şubat</option>
                      <option value="3">Mart</option>
                      <option value="4">Nisan</option>
                      <option value="5">Mayıs</option>
                      <option value="6">Haziran</option>
                      <option value="7">Temmuz</option>
                      <option value="8">Ağustos</option>
                      <option value="9">Eylül</option>
                      <option value="10">Ekim</option>
                      <option value="11">Kasım</option>
                      <option value="12">Aralık</option>
                    </Form.Select>
                    <Form.Control
                      type="text"
                      placeholder="CVV"
                      style={{ padding: ".6rem", width: "30%" }}
                    />
                  </div>
                  <InputGroup className="mb-3" style={{ marginTop: "1rem" }}>
                    <InputGroup.Checkbox aria-label="Checkbox for following text input" />
                    {"  "}
                    <strong>
                      <i className="ri-secure-payment-line"></i> 3D Secure
                    </strong>
                    {"  "}ile öde
                  </InputGroup>
                </div>
                <div>
                  <h3>Taksit Seçenekleri</h3>
                </div>
              </div>
            </div>
            {/* Sözleşme ile ilgili yazılar */}
            <div
              style={{
                marginTop: "2rem",
                border: "1px solid gray",
                padding: "1rem",
              }}
            >
              <h3>Sözleşmeler ve Formlar</h3>
              <h5 style={{ marginTop: "2rem", marginBottom: "1rem" }}>
                Cayma Hakkı
              </h5>
              <p
                style={{
                  padding: "2rem",
                  overflowY: "scroll",
                  height: "30px",
                  fontSize: "13px",
                  border: "1px solid gray",
                  borderRadius: "12px",
                }}
              >
                Nasıl İade Ederim? <br></br>
                <br></br>1. "Hesabım" > “Siparişlerim'' > “Sipariş detay”
                adımlarını takip edin. <br></br>2. İade Kargo Kodu Oluştur
                butonuna tıklayın. <br></br>3. İade edilecek ürün ve iade nedeni
                seçin. Aynı üründen birden fazla satın aldıysanız iade edilecek
                ürün adedini de seçmeniz gerekir. <br></br>4. İade etmek
                istediğiniz ürünlerin uygunluğuna göre size önerilen iade
                yöntemlerinden birini seçin.
                <br></br>5. Birden fazla kargo seçeneği çıktığı durumda kargo
                seçiminizi yapın. <br></br>6. Ekranda çıkan iade kargo kodunu
                not alın. İade kargo kodunuza siparişlerim sayfasından da
                ulaşabilirsiniz. <br></br>7. İade kodu aynı olan ürünleri
                faturasıyla beraber aynı pakete koyun ve paketin sağlam
                olduğundan emin olun. <br></br>8. İade kodu farklı olan ürünler
                aynı kargoya verilse bile farklı paketler halinde verilmelidir.{" "}
                <br></br>9. Seçtiğiniz iade yöntemine göre 7 gün içinde
                paketinizi seçeceğiniz gel al noktası veya kargo şubesine teslim
                edin veya randevu gününde adresinize gelecek görevliye teslim
                edin. <br></br>10. 7 günü geçirdiğiniz durumda yeniden iade
                kargo kodu almanız gerekir. <br></br>
                <br></br>İade Koşulları: <br></br>1. Ürünün paketi hasar
                görmemiş ve kullanılmamış olması gerekmektedir.<br></br>2-
                Ürünün tüm aksesuarları ve orijinal kutusu ile beraber iade
                edilmesi gerekmektedir. <br></br>3- Aşağıdaki ürün gruplarının
                ambalajı açılmamış, denenmemiş, bozulmamış ve kullanılmamış
                olmaları halinde iadesi kabul edilir. • Sağlık ve hijyen
                açısından uygun olmayan ürünlerin (Kozmetik ve kişisel bakım
                ürünleri,parfüm, epilatör, tıraş makinesi, kulaklık, iç giyim
                ürünleri, mayo, bikini vb.) • Kopyalanabilir yazılım ve
                programlar (DVD, VCD, CD, kasetler vb.) • Kitap ve kırtasiye
                sarf malzemeleri (toner, kartuş, şerit vb.) <br></br>4- Tek
                kullanımlık ürünlerin ve hızlı bozulan veya son kullanma tarihi
                geçme ihtimali olan ürünlerin iadesi kabul edilmemektedir.
              </p>
              <h5 style={{ marginTop: "2rem", marginBottom: "1rem" }}>
                Ön Bilgilendirme Formu
              </h5>
              <p
                style={{
                  padding: "2rem",
                  overflowY: "scroll",
                  height: "30px",
                  fontSize: "13px",
                  border: "1px solid gray",
                  borderRadius: "12px",
                }}
              >
                1. "Hesabım" > “Siparişlerim'' > “Sipariş detay” adımlarını
                takip edin. <br></br>2. İade Kargo Kodu Oluştur butonuna
                tıklayın. <br></br>3. İade edilecek ürün ve iade nedeni seçin.
                Aynı üründen birden fazla satın aldıysanız iade edilecek ürün
                adedini de seçmeniz gerekir. <br></br>4. İade etmek istediğiniz
                ürünlerin uygunluğuna göre size önerilen iade yöntemlerinden
                birini seçin.
                <br></br>5. Birden fazla kargo seçeneği çıktığı durumda kargo
                seçiminizi yapın. <br></br>6. Ekranda çıkan iade kargo kodunu
                not alın. İade kargo kodunuza siparişlerim sayfasından da
                ulaşabilirsiniz. <br></br>7. İade kodu aynı olan ürünleri
                faturasıyla beraber aynı pakete koyun ve paketin sağlam
                olduğundan emin olun. <br></br>8. İade kodu farklı olan ürünler
                aynı kargoya verilse bile farklı paketler halinde verilmelidir.{" "}
                <br></br>9. Seçtiğiniz iade yöntemine göre 7 gün içinde
                paketinizi seçeceğiniz gel al noktası veya kargo şubesine teslim
                edin veya randevu gününde adresinize gelecek görevliye teslim
                edin. <br></br>10. 7 günü geçirdiğiniz durumda yeniden iade
                kargo kodu almanız gerekir. <br></br>
                <br></br>İade Koşulları: <br></br>1. Ürünün paketi hasar
                görmemiş ve kullanılmamış olması gerekmektedir.<br></br>2-
                Ürünün tüm aksesuarları ve orijinal kutusu ile beraber iade
                edilmesi gerekmektedir. <br></br>3- Aşağıdaki ürün gruplarının
                ambalajı açılmamış, denenmemiş, bozulmamış ve kullanılmamış
                olmaları halinde iadesi kabul edilir. • Sağlık ve hijyen
                açısından uygun olmayan ürünlerin (Kozmetik ve kişisel bakım
                ürünleri,parfüm, epilatör, tıraş makinesi, kulaklık, iç giyim
                ürünleri, mayo, bikini vb.) • Kopyalanabilir yazılım ve
                programlar (DVD, VCD, CD, kasetler vb.) • Kitap ve kırtasiye
                sarf malzemeleri (toner, kartuş, şerit vb.) <br></br>4- Tek
                kullanımlık ürünlerin ve hızlı bozulan veya son kullanma tarihi
                geçme ihtimali olan ürünlerin iadesi kabul edilmemektedir.
              </p>
              <h5 style={{ marginTop: "2rem", marginBottom: "1rem" }}>
                Ön Bilgilendirme Formu
              </h5>
              <p
                style={{
                  padding: "2rem",
                  overflowY: "scroll",
                  height: "30px",
                  fontSize: "13px",
                  border: "1px solid gray",
                  borderRadius: "12px",
                }}
              >
                Nasıl İade Ederim? <br></br>
                <br></br>1. "Hesabım" > “Siparişlerim'' > “Sipariş detay”
                adımlarını takip edin. <br></br>2. İade Kargo Kodu Oluştur
                butonuna tıklayın. <br></br>3. İade edilecek ürün ve iade nedeni
                seçin. Aynı üründen birden fazla satın aldıysanız iade edilecek
                ürün adedini de seçmeniz gerekir. <br></br>4. İade etmek
                istediğiniz ürünlerin uygunluğuna göre size önerilen iade
                yöntemlerinden birini seçin.
                <br></br>5. Birden fazla kargo seçeneği çıktığı durumda kargo
                seçiminizi yapın. <br></br>6. Ekranda çıkan iade kargo kodunu
                not alın. İade kargo kodunuza siparişlerim sayfasından da
                ulaşabilirsiniz. <br></br>7. İade kodu aynı olan ürünleri
                faturasıyla beraber aynı pakete koyun ve paketin sağlam
                olduğundan emin olun. <br></br>8. İade kodu farklı olan ürünler
                aynı kargoya verilse bile farklı paketler halinde verilmelidir.{" "}
                <br></br>9. Seçtiğiniz iade yöntemine göre 7 gün içinde
                paketinizi seçeceğiniz gel al noktası veya kargo şubesine teslim
                edin veya randevu gününde adresinize gelecek görevliye teslim
                edin. <br></br>10. 7 günü geçirdiğiniz durumda yeniden iade
                kargo kodu almanız gerekir. <br></br>
                <br></br>İade Koşulları: <br></br>1. Ürünün paketi hasar
                görmemiş ve kullanılmamış olması gerekmektedir.<br></br>2-
                Ürünün tüm aksesuarları ve orijinal kutusu ile beraber iade
                edilmesi gerekmektedir. <br></br>3- Aşağıdaki ürün gruplarının
                ambalajı açılmamış, denenmemiş, bozulmamış ve kullanılmamış
                olmaları halinde iadesi kabul edilir. • Sağlık ve hijyen
                açısından uygun olmayan ürünlerin (Kozmetik ve kişisel bakım
                ürünleri,parfüm, epilatör, tıraş makinesi, kulaklık, iç giyim
                ürünleri, mayo, bikini vb.) • Kopyalanabilir yazılım ve
                programlar (DVD, VCD, CD, kasetler vb.) • Kitap ve kırtasiye
                sarf malzemeleri (toner, kartuş, şerit vb.) <br></br>4- Tek
                kullanımlık ürünlerin ve hızlı bozulan veya son kullanma tarihi
                geçme ihtimali olan ürünlerin iadesi kabul edilmemektedir.
              </p>
            </div>
          </div>
        )}

        <div className="myCart-price">
          <div
            style={{
              display: "flex",
              justifyContent: "space-between",
              fontSize: ".75rem",
              alignItems: "center",
              columnGap: "1.5rem",
            }}
          >
            <h3>Ürün Toplamı</h3>
            <p>27.025,95 TL</p>
          </div>
          <div
            style={{
              display: "flex",
              justifyContent: "space-between",
              paddingBottom: "1rem",
              borderBottom: "1px solid gray",
              fontSize: ".75rem",
              alignItems: "center",
            }}
          >
            <h3>Kargo Toplamı</h3>
            34,95 TL
          </div>
          <div style={{ marginTop: "1rem" }}>
            <p>İndirim Kodu</p>
            <div style={{ display: "flex" }}>
              <input></input>
              <button
                style={{
                  backgroundColor: "red",
                  color: "white",
                  border: "none",
                  padding: " .5rem",
                  cursor: "pointer",
                }}
              >
                Kullan
              </button>
            </div>
          </div>
          <button
            style={{
              marginTop: "1rem",
              padding: "2rem",
              width: "100%",
              border: "none",
              cursor: "pointer",
              backgroundColor: "black",
              color: "white",
            }}
            onClick={() => {
              if (myCartOption.first == true) {
                clickMyCartOption("second");
              } else {
                clickMyCartOption("third");
              }
            }}
          >
            Sepeti Onayla
          </button>
        </div>
      </div>

      <h2 style={{ marginTop: "2.5rem" }}>Bunları da düşünebilirsiniz!</h2>
      <div className="myCart-recommended-products">
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
      </div>
    </div>
  );
}

export default MyCart;
