import { AttributeTypeMap } from "./models";
export declare class AccountResponseQuotas {
    "apiSignatureRequestsLeft"?: number | null;
    "documentsLeft"?: number | null;
    "templatesTotal"?: number | null;
    "templatesLeft"?: number | null;
    "smsVerificationsLeft"?: number | null;
    static discriminator: string | undefined;
    static attributeTypeMap: AttributeTypeMap;
    static getAttributeTypeMap(): AttributeTypeMap;
    static init(data: any): AccountResponseQuotas;
}
