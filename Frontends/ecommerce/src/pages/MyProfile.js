import React, { useState } from "react";
import "../pages/MyProfile.css";

function MyProfile() {
  const [profileOption, setProfileOption] = useState({
    account: true,
    password: false,
    package: false,
    order: false,
    notification: false,
  });

  const [myPackage, setMyPackage] = useState("gold");

  const clickProfileOption = (option) => {
    setProfileOption({
      account: option === "account",
      password: option === "password",
      package: option === "package",
      order: option === "order",
      notification: option === "notification",
    });
  };

  return (
    <div className="myProfile">
      <p className="myProfile-welcome-text">Hoşgeldin imertak!</p>
      <div className="myProfile-detail">
        <div className="myProfile-detail-options">
          <p className="myProfile-detail-options-username">imertak</p>
          <div className="myProfile-detail-options-list">
            <p onClick={() => clickProfileOption("account")}>Hesabım</p>
            <p onClick={() => clickProfileOption("password")}>Şifre</p>
            <p onClick={() => clickProfileOption("package")}>Paketim</p>
            <p onClick={() => clickProfileOption("order")}>Siparişlerim</p>
            <p onClick={() => clickProfileOption("notification")}>
              Bildirimler
            </p>
            <p className="myProfile-detail-options-list-logout">
              <i className="ri-shut-down-line"></i> Çıkış Yap
            </p>
          </div>
        </div>
        <div className="myProfile-detail-settings">
          {profileOption.account && (
            <div className="myProfile-detail-settings-account">
              <h2>Hesap Ayarları</h2>
              <div className="myProfile-detail-settings-account-input">
                <input placeholder="İsim" />
                <input placeholder="Soyisim" />
                <input placeholder="E-posta" />
                <input placeholder="Telefon" />
                <input placeholder="Adres" id="myProfile-settings-address" />
              </div>
              <button>Güncelle</button>
            </div>
          )}
          {profileOption.password && (
            <div className="myProfile-detail-settings-account">
              <h2>Şifre Ayarları</h2>
              <input placeholder="Eski Şifre" />
              <br />
              <a
                href="/sifremi-unuttum"
                style={{ cursor: "pointer", textDecoration: "underline" }}
              >
                Şifremi unuttum.
              </a>
              <br />
              <input placeholder="Yeni Şifre" />
              <input placeholder="Yeni Şifre Onay" />
              <button>Güncelle</button>
            </div>
          )}
          {profileOption.package && (
            <div>
              <h2>Toplam Puan: 2129</h2>
              <div className="myProfile-detail-settings-package">
                <div
                  className={`myProfile-detail-settings-package-item ${
                    myPackage === "bronze" ? "active" : ""
                  }`}
                >
                  <h2>Bronz Paket</h2>
                  <p>
                    Ücretsiz Üyelik: Kullanıcılar ücretsiz olarak üye
                    olabilirler. Temel Özellikler: Temel ürün arama, ürün
                    inceleme ve sipariş oluşturma özellikleri. Sınırlı
                    İndirimler: Özel satış etkinliklerinde sınırlı indirimlerden
                    faydalanabilirler. E-posta Bildirimleri: Özel teklifler ve
                    promosyonlar hakkında e-posta bildirimleri alabilirler. İade
                    ve Değişim Hakkı: Ürün iade ve değişim sürecinde öncelikli
                    hizmet.
                  </p>
                </div>
                <div
                  className={`myProfile-detail-settings-package-item ${
                    myPackage === "silver" ? "active" : ""
                  }`}
                >
                  <h2>Silver Paket</h2>
                  <p>
                    Orta Seviye Ücret: Makul bir ücret karşılığında daha fazla
                    ayrıcalık sunar. Tüm Bronz Özellikler: Bronz üyelik
                    paketindeki tüm özellikleri içerir. Genişletilmiş
                    İndirimler: Ürünlerde daha geniş indirimlerden
                    faydalanabilirler. Öncelikli Müşteri Desteği: Hızlı ve
                    öncelikli müşteri hizmetleri desteği. Özel Ürün Önerileri:
                    Alışveriş geçmişlerine göre kişiselleştirilmiş ürün
                    önerileri alabilirler.
                  </p>
                </div>
                <div
                  className={`myProfile-detail-settings-package-item ${
                    myPackage === "gold" ? "active" : ""
                  }`}
                >
                  <h2>Gold Paket</h2>
                  <p>
                    Premium Ücret: En yüksek seviyede ayrıcalıklı hizmetler
                    sunar. Tüm Gold Özellikler: Gold üyelik paketindeki tüm
                    özellikleri içerir. Ekstra İndirimler: Daha fazla üründe ve
                    daha yüksek indirim oranlarında avantajlar. Hediye
                    Paketleri: Özel günlerde veya belirli dönemlerde ücretsiz
                    hediye paketleri. Öncelikli Kargo: Diğer müşterilere göre
                    daha hızlı ve öncelikli kargo hizmeti.
                  </p>
                </div>
                <div
                  className={`myProfile-detail-settings-package-item ${
                    myPackage === "star" ? "active" : ""
                  }`}
                >
                  <h2>Star Paket</h2>
                  <p>
                    Premium Ücret: En yüksek seviyede ayrıcalıklı hizmetler
                    sunar. Tüm Gold Özellikler: Gold üyelik paketindeki tüm
                    özellikleri içerir. Ekstra İndirimler: Daha fazla üründe ve
                    daha yüksek indirim oranlarında avantajlar. Hediye
                    Paketleri: Özel günlerde veya belirli dönemlerde ücretsiz
                    hediye paketleri. Öncelikli Kargo: Diğer müşterilere göre
                    daha hızlı ve öncelikli kargo hizmeti.
                  </p>
                </div>
              </div>
            </div>
          )}
        </div>
      </div>
    </div>
  );
}

export default MyProfile;
