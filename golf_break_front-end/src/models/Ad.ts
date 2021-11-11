import { AdImage } from "./AdImage";
import { LeadProduct } from "./LeadProduct";
import { Venue } from "./Venue";

export interface Ad {
    url: string;
    full_name: string;
    parent_location: string;
    lead_product: LeadProduct;
    data: Venue[];
    image: AdImage;
}