using System;
class SinhVien
{
    public string Ten { get; set; }
    public int Tuoi { get; set; }
    public string Khoa { get; set; }
    public double DiemTB { get; set; }
    public int NamHoc { get; set; }

    public SinhVien(string ten, int tuoi, string khoa, double diemTB, int namHoc)
    {
        Ten = ten;
        Tuoi = tuoi;
        Khoa = khoa;
        DiemTB = diemTB;
        NamHoc = namHoc;
    }

    public override string ToString()
    {
        return $"{Ten}\t| Tuoi: {Tuoi} | Khoa: {Khoa}\t| DiemTB: {DiemTB}\t| Nam: {NamHoc}";
    }
}